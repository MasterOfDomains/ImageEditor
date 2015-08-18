using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ImageEditor.Editing
{
    class EditorImage
    {
        public enum ResizeTypes
        {
            Percent,
            Pixels
        }

        public enum ResizeDirections
        {
            Vertical,
            Horizontal
        }

        public Bitmap StartImg { get; private set; }
        public Bitmap AlteredImg { get; private set; }
        public string ImgName { get; private set; }
        public string ImgFullPath { get; private set; }
        public ImageFormat ImgFormat { get; private set; }

        public EditorCrop Crop { get; private set; }
        public bool HasCrop { get; private set; }

        public EditorImage(Bitmap bitmap, string imgName, string imgFullPath, ImageFormat format)
        {
            StartImg = bitmap;
            AlteredImg = (Bitmap)StartImg.Clone();
            ImgName = imgName;
            ImgFullPath = imgFullPath;
            ImgFormat = format;
        }

        public void Save()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (System.IO.File.Exists(@ImgFullPath))
                {
                    AlteredImg.Save(stream, ImgFormat);
                    StartImg.Dispose();
                    try
                    {
                        //System.IO.File.Delete(@ImgFullPath);
                    }
                    catch (System.UnauthorizedAccessException)
                    {

                    }
                    AlteredImg = new Bitmap(stream);
                }
                AlteredImg.Save(@ImgFullPath, ImgFormat);
                stream.Close();
            }
            StartImg = (Bitmap)AlteredImg.Clone();
        }

        public void Reset()
        {
            AlteredImg = (Bitmap)StartImg.Clone();
            HasCrop = false;
        }

        public bool ResizeCropWidth(int width)
        {
            bool fits = true;
            if (HasCrop)
            {
                if (width <= this.GetRectangle().Width)
                    Crop.ResizeWidth(width, this.GetRectangle().Width);
                else
                    fits = false;
            }
            return fits;
        }

        public bool ResizeCropHeight(int height)
        {
            bool fits = true;
            if (HasCrop)
            {
                if (height <= this.GetRectangle().Height)
                    Crop.ResizeHeight(height, this.GetRectangle().Height);
                else
                    fits = false;
            }
            return fits;
        }

        public void CropImage()
        {
            if (HasCrop)
            {
                using (Bitmap PlaceholderImg = new Bitmap(Crop.GetRectangle().Width, Crop.GetRectangle().Height))
                {
                    using (Graphics g = Graphics.FromImage(PlaceholderImg))
                    {
                        g.DrawImage(AlteredImg, new Rectangle(0, 0, PlaceholderImg.Width, PlaceholderImg.Height),
                                        Crop.GetRectangle(),
                                        GraphicsUnit.Pixel); // Overload 11 of 30
                    }

                    AlteredImg.Dispose();
                    AlteredImg = (Bitmap)PlaceholderImg.Clone();
                    HasCrop = false;
                }
            }
        }

        public void RemoveCrop()
        {
            HasCrop = false;
        }

        public bool AddCrop(Size size)
        {
            bool success = false;
            if (!HasCrop)
            {
                if (size.Height < AlteredImg.Height && size.Width < AlteredImg.Width)
                {
                    Point point = new Point();
                    point.X = (AlteredImg.Width / 2) - (size.Width / 2);
                    point.Y = (AlteredImg.Height / 2) - (size.Height / 2);
                    Crop = new EditorCrop(point, size);
                    HasCrop = true;
                    success = true;
                }
            }
            return success;
        }

        public void MoveCrop(int x, int y)
        {
            this.Crop.Move(x, y, this.GetRectangle().Size);
        }

        public bool ChangeSize(decimal change, ResizeTypes type, ResizeDirections dir, out decimal pctChange)
        {
            bool success = true;
            pctChange = 0;
            int newHeight = AlteredImg.Height;
            int newWidth = AlteredImg.Width;

            if (type == ResizeTypes.Percent)
            {
                decimal multiplier = 1.00m + (change / 100);
                if (dir == ResizeDirections.Vertical)
                {
                    decimal decNewHeight = (StartImg.Height * multiplier);
                    decimal decNewWidth = (StartImg.Width * multiplier);
                    newHeight = (int)decNewHeight;
                    newWidth = (int)decNewWidth;
                    pctChange = change;
                }
            }
            else if (type == ResizeTypes.Pixels)
            {
                if (dir == ResizeDirections.Vertical)
                {
                    newHeight = AlteredImg.Height + (int)change;
                    decimal newHeightPct = ((decimal)newHeight / (decimal)AlteredImg.Height);
                    newWidth = (int)Math.Round(AlteredImg.Width * newHeightPct);
                }
                else if (dir == ResizeDirections.Horizontal)
                {
                    newWidth = AlteredImg.Width + (int)change;
                    decimal newWidthPct = ((decimal)newWidth / (decimal)AlteredImg.Width);
                    newHeight = (int)Math.Round(AlteredImg.Height * newWidthPct);
                }
                pctChange = (((decimal)newHeight / (decimal)StartImg.Height) - 1) * 100.0m;
            }

            if (HasCrop)
            {
                if (change < 0) // Decreasing image size
                {
                    if (Crop.GetRectangle().Bottom >= this.GetRectangle().Bottom ||
                        Crop.GetRectangle().Right >= this.GetRectangle().Right)
                        success = false;
                }
            }

            if (success)
            {
                AlteredImg.Dispose();
                AlteredImg = new Bitmap(StartImg, new Size { Width = newWidth, Height = newHeight });
            }

            return success;
        }

        public override string ToString()
        {
            return "H: " + AlteredImg.Height + " W: " + AlteredImg.Width;
        }

        public Rectangle GetRectangle()
        {
            Rectangle rectangle = new Rectangle(0, 0, AlteredImg.Width, AlteredImg.Height);
            return rectangle;
        }
    }
}

