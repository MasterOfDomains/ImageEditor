using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageEditor
{
    public partial class frmMain : Form
    {
        EditorImage currentImage;
        public delegate bool ResizeMethod(int dimension);
        CropProfile currentProfile;
        Pen pen;

        BorderHelper imgBorderHelper;
        BorderHelper cropBorderHelper;

        private const int mouseError = 5;
        private enum MouseTasks
        {
            None,
            ReadyResizeImageVertical,
            ResizeImageVertical,
            ReadyResizeImageHorizontal,
            ResizeImageHorizontal,
            ReadyMoveCrop,
            MoveCrop
        }
        private MouseTasks currentMouseTask =  MouseTasks.None;

        private Point mouseStart;
        private Point mouseEnd;

        public frmMain()
        {
            InitializeComponent();
        }

        /*
         * Methods
         * */

        private void ChangeSize(decimal amount, 
                                EditorImage.ResizeTypes type, 
                                EditorImage.ResizeDirections dir)
        {
            decimal newNudSizeVal;
            if (currentImage.ChangeSize(amount, type, dir, out newNudSizeVal))
            {
                txtImgHeight.Text = currentImage.AlteredImg.Height.ToString();
                txtImgWidth.Text = currentImage.AlteredImg.Width.ToString();
                btnRollBack.Enabled = true;
                btnSave.Enabled = true;
                nudImageSize.Value = newNudSizeVal;
                pbxImage.Image = currentImage.AlteredImg;
            }
        }

        public void RefitForCrop()
        {
            if (currentImage.AlteredImg.Height < currentImage.Crop.GetRectangle().Bottom ||
                currentImage.AlteredImg.Width < currentImage.Crop.GetRectangle().Right)
            {
                int heightDiff = Math.Abs(currentImage.Crop.GetRectangle().Bottom - currentImage.AlteredImg.Height);
                int widthDiff = Math.Abs(currentImage.Crop.GetRectangle().Right - currentImage.AlteredImg.Width);

                if (heightDiff > widthDiff)
                    ChangeSize(heightDiff, EditorImage.ResizeTypes.Pixels, EditorImage.ResizeDirections.Vertical);
                else
                    ChangeSize(widthDiff, EditorImage.ResizeTypes.Pixels, EditorImage.ResizeDirections.Horizontal);
            }
        }

        private void OpenImage()
        {
            using (OpenFileDialog dlgGetImage = new OpenFileDialog())
            {
                dlgGetImage.InitialDirectory = currentProfile.ImageDirectory;
                dlgGetImage.Filter = "All Files(*.*)|*.*|JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";

                if (dlgGetImage.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(dlgGetImage.FileName);
                    string imgName = dlgGetImage.SafeFileName;
                    string imgFullPath = dlgGetImage.FileName;
                    currentImage = new EditorImage(bitmap, imgName, imgFullPath, bitmap.GetImageFormat());
                    imgBorderHelper = new BorderHelper(currentImage.GetRectangle(), mouseError);
                    txtCurrentImg.Text = currentImage.ImgName;
                    txtImgHeight.Text = currentImage.StartImg.Height.ToString();
                    txtImgWidth.Text = currentImage.StartImg.Width.ToString();
                    btnSelectBoundary.Enabled = true;
                    nudImageSize.Enabled = true;
                    nudImageSize.Value = 0;
                    pbxImage.Image = currentImage.StartImg;
                }
            }
        }

        private void SaveImage()
        {
            DialogResult res = MessageBox.Show("Save over " + txtCurrentImg.Text + "?", "Save", MessageBoxButtons.YesNo);
            currentImage.Save();
        }

        private void ResetMouse()
        {
            currentMouseTask = MouseTasks.None;
            this.Cursor = Cursors.Default;
        }

        /*
         * Button Event Handlers
         * */

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenImage();
            if (currentImage != null)
                imgBorderHelper = new BorderHelper(currentImage.GetRectangle(), mouseError);
        }

        private void btnChangeImageDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlgImageFolder = new FolderBrowserDialog())
            {
                if (dlgImageFolder.ShowDialog() == DialogResult.OK)
                {
                    currentProfile.ImageDirectory = dlgImageFolder.SelectedPath;
                    txtDefaultImageDir.Text = currentProfile.ImageDirectory;
                }
            }
        }

        private void btnRollBack_Click(object sender, EventArgs e)
        {
            currentImage.Reset();
            pbxImage.Image = currentImage.AlteredImg;
            txtImgHeight.Text = currentImage.AlteredImg.Height.ToString();
            txtImgWidth.Text = currentImage.AlteredImg.Width.ToString();
        }

        private void btnCropColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlgColor = new ColorDialog())
            {
                dlgColor.Color = Color.FromArgb(currentProfile.CropColor);
                if (dlgColor.ShowDialog() == DialogResult.OK)
                {
                    currentProfile.CropColor = dlgColor.Color.ToArgb();
                    pen.Color = dlgColor.Color;
                    pbxImage.Invalidate();
                }
            }
        }

        private void btnSelectBoundary_Click(object sender, EventArgs e)
        {
            txtBoundHeight.Enabled = true;
            txtBoundWidth.Enabled = true;
            txtBoundHeight.Text = currentProfile.Height.ToString();
            txtBoundWidth.Text = currentProfile.Width.ToString();
            btnSetBounds.Enabled = true;
            btnCropColor.Enabled = true;
            currentImage.RemoveCrop();

            if (currentImage.AddCrop(new Size { Height = currentProfile.Height, Width = currentProfile.Width }))
            {
                pbxImage.Invalidate();
                cropBorderHelper = new BorderHelper(currentImage.Crop.GetRectangle(), mouseError);
                btnCrop.Enabled = true;
            }
            else
                MessageBox.Show("Crop bounds must be smaller than image bounds.");
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            currentImage.CropImage();
            pbxImage.Image = currentImage.AlteredImg;
            txtImgHeight.Text = currentImage.AlteredImg.Height.ToString();
            txtImgWidth.Text = currentImage.AlteredImg.Width.ToString();
            btnCrop.Enabled = false;
            btnRollBack.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveImage();
            currentImage.RemoveCrop();
            btnCrop.Enabled = false;
            btnSave.Enabled = false;
            btnRollBack.Enabled = false;
        }

        /*
         * Mouse Event Handlers
         * */

        private void pbxImage_MouseLeave(object sender, EventArgs e)
        {
            ResetMouse();
        }

        private void pbxImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (pbxImage.Image != null)
            {
                if (currentMouseTask == MouseTasks.ReadyResizeImageVertical)
                {
                    currentMouseTask = MouseTasks.ResizeImageVertical;
                    mouseStart.Y = e.Location.Y;
                }
                else if (currentMouseTask == MouseTasks.ReadyResizeImageHorizontal)
                {
                    currentMouseTask = MouseTasks.ResizeImageHorizontal;
                    mouseStart.X = e.Location.X;
                }
                else if (currentMouseTask == MouseTasks.ReadyMoveCrop)
                {
                    currentMouseTask = MouseTasks.MoveCrop;
                    mouseStart.X = e.Location.X;
                    mouseStart.Y = e.Location.Y;
                }
            }
        }

        private void pbxImage_MouseUp(object sender, MouseEventArgs e)
        {
            currentMouseTask = MouseTasks.None;
            this.Cursor = Cursors.Default;
            if (currentImage.HasCrop)
            {
                if (currentImage.Crop.GetRectangle().Bottom > currentImage.GetRectangle().Bottom ||
                    currentImage.Crop.GetRectangle().Right > currentImage.GetRectangle().Right)
                {
                    int heightAdjust, widthAdjust;
                    heightAdjust = currentImage.Crop.GetRectangle().Height;
                    widthAdjust = currentImage.Crop.GetRectangle().Width;
                    RefitForCrop();
                }
            }
        }

        private void pbxImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbxImage.Image != null)
            {
                if (currentMouseTask == MouseTasks.ResizeImageVertical)
                {
                    mouseEnd.Y = e.Location.Y;
                    int heightChange = mouseEnd.Y - mouseStart.Y;
                    mouseStart = mouseEnd;
                    ChangeSize(heightChange,
                               EditorImage.ResizeTypes.Pixels,
                               EditorImage.ResizeDirections.Vertical);
                }
                else if (currentMouseTask == MouseTasks.ResizeImageHorizontal)
                {
                    mouseEnd.X = e.Location.X;
                    int widthChange = mouseEnd.X - mouseStart.X;
                    mouseStart = mouseEnd;
                    ChangeSize(widthChange,
                               EditorImage.ResizeTypes.Pixels,
                               EditorImage.ResizeDirections.Horizontal);
                }
                else if (currentMouseTask == MouseTasks.MoveCrop)
                {
                    mouseEnd.X = e.Location.X;
                    mouseEnd.Y = e.Location.Y;
                    int moveX = mouseEnd.X - mouseStart.X;
                    int moveY = mouseEnd.Y - mouseStart.Y;
                    mouseStart.X = mouseEnd.X;
                    mouseStart.Y = mouseEnd.Y;
                    currentImage.MoveCrop(moveX, moveY);
                    pbxImage.Invalidate(); // Needed
                }
                else
                { // Look for borders
                    currentMouseTask = MouseTasks.None;
                    if (currentImage.HasCrop == true)
                    {
                        BorderHelper.Border border = cropBorderHelper.getBorder(e.Location);
                        if (border != BorderHelper.Border.Exterior && border != BorderHelper.Border.Interior)
                        {
                            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
                            currentMouseTask = MouseTasks.ReadyMoveCrop;
                        }
                    }

                    if (pbxImage.Image != null)
                    {
                        BorderHelper.Border border = imgBorderHelper.getBorder(e.Location);
                        if (border != BorderHelper.Border.Exterior)
                        {
                            if (border == BorderHelper.Border.Bottom)
                            {
                                this.Cursor = System.Windows.Forms.Cursors.HSplit;
                                currentMouseTask = MouseTasks.ReadyResizeImageVertical;
                            }
                            else if (border == BorderHelper.Border.Right)
                            {
                                this.Cursor = System.Windows.Forms.Cursors.VSplit;
                                currentMouseTask = MouseTasks.ReadyResizeImageHorizontal;
                            }
                        }
                    }
                }

                if (currentMouseTask == MouseTasks.None)
                    this.Cursor = Cursors.Default;
            }
        }

        /*
         * Menu Event Handlers
         * */

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbxImage.Image = null;
            pbxImage.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCropProfile profiles = new frmCropProfile())
            {
                if (profiles.ShowDialog() == DialogResult.OK)
                {
                    Size cropSize = new Size(profiles.currentCropProfile.Width, 
                        profiles.currentCropProfile.Height);
                    if (currentImage != null)
                    {
                        currentImage.RemoveCrop();
                        if (currentImage.AddCrop(cropSize))
                        {
                            currentProfile = profiles.currentCropProfile;
                            txtBoundHeight.Text = currentProfile.Height.ToString();
                            txtBoundWidth.Text = currentProfile.Width.ToString();
                            txtDefaultImageDir.Text = currentProfile.ImageDirectory;
                            pen.Color = Color.FromArgb(currentProfile.CropColor);
                            pbxImage.Invalidate();
                        }
                        else
                            MessageBox.Show("You must first enlarge the picture for that crop size.");
                    }
                    else
                    {
                        currentProfile = profiles.currentCropProfile;
                        txtBoundHeight.Text = currentProfile.Height.ToString();
                        txtBoundWidth.Text = currentProfile.Width.ToString();
                        txtDefaultImageDir.Text = currentProfile.ImageDirectory;
                        pen.Color = Color.FromArgb(currentProfile.CropColor);
                    }
                }
            }
        }

        private void saveProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmCropProfile profile = new frmCropProfile(currentProfile))
            {
                profile.ShowDialog();
            }
        }

        /*
         * Other Event Handlers
         * */

        private void btnSetBounds_Click(object sender, EventArgs e)
        {
        }

        private void txtBoundHeight_Leave(object sender, EventArgs e)
        {
            bool success = false;
            int newHeight;
            if (Int32.TryParse(txtBoundHeight.Text, out newHeight))
            {
                success = currentImage.ResizeCropHeight(newHeight);
                if (success)
                {
                    currentProfile.Height = newHeight;
                    pbxImage.Invalidate();
                }
                else
                    MessageBox.Show("That crop height is too large.");
            }
            else
                MessageBox.Show("Height must be integer.");
            if (!success)
                txtBoundHeight.Text = currentImage.AlteredImg.Height.ToString();
        }

        private void txtBoundWidth_Leave(object sender, EventArgs e)
        {
            bool success = false;
            int newWidth;
            if (Int32.TryParse(txtBoundWidth.Text, out newWidth))
            {
                success = currentImage.ResizeCropWidth(newWidth);
                if (success)
                {
                    currentProfile.Width = newWidth;
                    pbxImage.Invalidate();
                }
                else
                    MessageBox.Show("That crop width is too large.");
            }
            else
                MessageBox.Show("Width must be integer.");
            if (!success)
                txtBoundWidth.Text = currentImage.AlteredImg.Width.ToString();
        }

        private void pbxImage_Paint(object sender, PaintEventArgs e)
        {
            if (pbxImage.Image != null)
            {
                imgBorderHelper = new BorderHelper(currentImage.GetRectangle(), mouseError);
                if (currentImage.HasCrop)
                {
                    Graphics graphics = e.Graphics;
                    graphics.DrawRectangle(pen, currentImage.Crop.GetRectangle());
                    cropBorderHelper = new BorderHelper(currentImage.Crop.GetRectangle(), mouseError);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            currentProfile = new CropProfile();
            currentProfile.Name = "Temp Name";
            currentProfile.Height = 200;
            currentProfile.Width = 200;
            currentProfile.ImageDirectory = "C:\\";
            currentProfile.CropColor = 0x780000FF;

            txtDefaultImageDir.Text = currentProfile.ImageDirectory;
            pen = new Pen(Color.FromArgb(currentProfile.CropColor));
        }

        private void nudImageSize_ValueChanged(object sender, EventArgs e)
        {
            if (currentMouseTask == MouseTasks.None)
            {
                ChangeSize(nudImageSize.Value,
                           EditorImage.ResizeTypes.Percent,
                           EditorImage.ResizeDirections.Vertical);
            }
        }

        private void splRight_MouseLeave(object sender, EventArgs e)
        {
            ResetMouse();
        }

        private void splTopLeft_Panel2_MouseEnter(object sender, EventArgs e)
        {
            ResetMouse();
        }

        private void pnlCropControls_MouseEnter(object sender, EventArgs e)
        {
            ResetMouse();
        }

        private void pnlImgSizeControls_MouseEnter(object sender, EventArgs e)
        {
            ResetMouse();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            ResetMouse();
        }

        private void splRight_Panel2_MouseEnter(object sender, EventArgs e)
        {
            ResetMouse();
        }
    }
}

