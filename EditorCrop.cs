using System.Drawing;

namespace ImageEditor
{
    class EditorCrop
    {
        private Rectangle rectangle;

        public EditorCrop(Point point, Size size)
        {
            rectangle = new Rectangle(point, size);
        }

        public void Move(int x, int y, Size containerSize)
        {
            int offsetX = x;
            int offsetY = y;

            if (x < 0) // Moving Left
            {
                if (rectangle.Left + offsetX < 0)
                    offsetX = 0;
            }
            else if (x > 0) // Moving Right
            {
                if (rectangle.Right + offsetX >= containerSize.Width)
                    offsetX = 0;
            }

            if (y < 0) // Moving Up
            {
                if (rectangle.Top + offsetY < 0)
                    offsetY = 0;
            }
            else if (y > 0) // Moving Down
            {
                if (rectangle.Bottom + offsetY >= containerSize.Height)
                    offsetY = 0;
            }

            rectangle.Offset(offsetX, offsetY);
        }

        public void ResizeHeight(int height, int containerHeight)
        {
            int yOffsetAdjust = (rectangle.Height - height) / 2;
            if (yOffsetAdjust + rectangle.Y < 0)
                rectangle.Y = 0;
            else if ((rectangle.Y + yOffsetAdjust + height) > containerHeight)
                rectangle.Y = containerHeight - height;
            else
                rectangle.Offset(0, yOffsetAdjust);
            rectangle.Height = height;
        }

        public void ResizeWidth(int width, int containerWidth)
        {
            int xOffsetAdjust = (rectangle.Width - width) / 2;
            if (xOffsetAdjust + rectangle.X < 0)
                rectangle.X = 0;
            else if ((rectangle.X + xOffsetAdjust + width) > containerWidth)
                rectangle.X = containerWidth - width;
            else
                rectangle.Offset(xOffsetAdjust, 0);
            rectangle.Width = width;
        }

        public override string ToString()
        {
            string returnVal = "";
            returnVal = "H: " + rectangle.Height;
            returnVal += " W: " + rectangle.Width;
            returnVal += " X: " + rectangle.X;
            returnVal += " Y: " + rectangle.Y;
            return returnVal;
        }

        public bool isOverBorder(Point mousePosition, int mouseError)
        {
            if (mousePosition.X > rectangle.Width - mouseError && mousePosition.X < rectangle.Width + mouseError)
                return true;
            else if (mousePosition.Y > rectangle.Height - mouseError && mousePosition.Y < rectangle.Height + mouseError)
                return true;
            else
                return false;
        }

        public Rectangle GetRectangle()
        {
            return rectangle;
        }
    }
}
