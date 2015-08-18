using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class frmCropProfile : Form
    {
        ImageEditorDataEntities _context;

        public CropProfile currentCropProfile { get; private set; }
        private CropProfile newProfile;

        public frmCropProfile() // Load saved profile
        {
            InitializeComponent();
            newProfile = null;
            btnLoad.Visible = true;
        }

        public frmCropProfile(CropProfile cropProfile) // Save current profile
        {
            InitializeComponent();
            newProfile = cropProfile;
            btnOk.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            currentCropProfile = new CropProfile();
            base.OnLoad(e);
            _context = new ImageEditorDataEntities();
            if (_context.CropProfiles.Count() > 0)
                _context.CropProfiles.Load();
            this.cropProfileBindingSource.DataSource =
                _context.CropProfiles.Local.ToBindingList();

            if (newProfile != null)
            {
                using (dlgNameProfile dlg = new dlgNameProfile())
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        newProfile.Name = dlg.ProfileName;
                        _context.CropProfiles.Add(newProfile);
                        _context.SaveChanges();
                        dgvCropProfiles.Refresh();
                        btnOk.Visible = true;
                        btnOk.Enabled = true;
                    }
                    else
                        this.Close();
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

        /*
         * Methods
         * */

        private bool GetRecord(DataGridViewRow row, bool alertError)
        {
            bool complete = true;
            string errorMessage = "This profile is incomplete:";
            string crlf = "\n\r";
            var cells = row.Cells;
            currentCropProfile.Name = cells["ProfileName"].Value.ToString();
            currentCropProfile.Height = (int)cells["DefaultHeight"].Value;
            currentCropProfile.Width = (int)cells["DefaultWidth"].Value;
            currentCropProfile.CropColor = (int)cells["CropColor"].Value;
            currentCropProfile.ImageDirectory = cells["DefaultDirectory"].Value.ToString();

            if (String.IsNullOrEmpty(currentCropProfile.Name))
            {
                complete = false;
                errorMessage += "Profile Name" + crlf;
            }
            if (String.IsNullOrEmpty(cells["DefaultDirectory"].Value.ToString()))
            {
                complete = false;
                errorMessage += "Default Directory" + crlf;
            }
            if (currentCropProfile.Height == 0 ||
                currentCropProfile.Width == 0)
            {
                complete = false;
                errorMessage += "Height and Width cannot be 0." + crlf;
            }
            if (currentCropProfile.CropColor == 0)
            {
                complete = false;
                errorMessage += "You must select a color." + crlf;
            }
            if (complete)
                btnLoad.Enabled = true;
            else
                MessageBox.Show(errorMessage);
            return complete;
        }
        
        private bool Save()
        {
            bool success = false;
            try
            {
                _context.SaveChanges();

                if (dgvCropProfiles.CurrentRow != null)
                {
                    if (GetRecord(dgvCropProfiles.CurrentRow, true))
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;

                }
                else
                    this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("There are invalid Fields. Changes will not be saved.");
            }
            return success;
        }

        /*
         * Button Event Handlers
         * */

        private void cropProfileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            Save();
            dgvCropProfiles.Refresh();
        }

        private void btnGetColor_Click(object sender, EventArgs e)
        {
            if (dgvCropProfiles.CurrentRow != null)
            {
                using (ColorDialog dlgColor = new ColorDialog())
                {
                    //if (currentCropProfile != null && currentCropProfile.CropColor != null)
                    //    dlgColor.Color = Color.FromName(currentCropProfile.CropColor);
                    if (dlgColor.ShowDialog() == DialogResult.OK)
                    {
                        currentCropProfile.CropColor = dlgColor.Color.ToArgb();
                        this.dgvCropProfiles.CurrentRow.Cells["CropColor"].Value = 
                            currentCropProfile.CropColor;
                    }
                }
            }
        }

        private void btnGetDir_Click(object sender, EventArgs e)
        {
            if (dgvCropProfiles.CurrentRow != null)
            {
                using (FolderBrowserDialog dlgImageFolder = new FolderBrowserDialog())
                {
                    if (currentCropProfile != null && currentCropProfile.ImageDirectory != null)
                        dlgImageFolder.SelectedPath = currentCropProfile.ImageDirectory;
                    if (dlgImageFolder.ShowDialog() == DialogResult.OK)
                    {
                        currentCropProfile.ImageDirectory = dlgImageFolder.SelectedPath;
                        this.dgvCropProfiles.CurrentRow.Cells["DefaultDirectory"].Value =
                            currentCropProfile.ImageDirectory;
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                if (dgvCropProfiles.CurrentRow != null)
                {
                    if (GetRecord(dgvCropProfiles.CurrentRow, true))
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;

                }
                else
                    this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        /*
         * Other Event Handlers
         * */

        private void dgvCropProfiles_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCropProfiles.CurrentRow != null)
            {
                if (dgvCropProfiles.CurrentRow.Cells["CropColor"].Selected)
                {
                    btnGetColor.Enabled = true;
                    btnGetDir.Enabled = false;
                }
                else if (dgvCropProfiles.CurrentRow.Cells["DefaultDirectory"].Selected)
                {
                    btnGetDir.Enabled = true;
                    btnGetColor.Enabled = false;
                }
                else
                {
                    btnGetDir.Enabled = false;
                    btnGetColor.Enabled = false;
                }
            }
        }
        
        private void dgvCropProfiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnLoad.Enabled = true;
        }

        private void dgvCropProfiles_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCropProfiles.Rows)
            {
                if (row.Cells["CropColor"].Value != null)
                {
                    int colorArgb = (int)row.Cells["CropColor"].Value;
                    Color color = Color.FromArgb(colorArgb);
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = color;
                    row.Cells["CropColor"].Style = style;
                }
            }
        }
    }
}
