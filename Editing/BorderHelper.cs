using System.Drawing;

namespace ImageEditor.Editing
{
    class BorderHelper
    {
        private Rectangle rectangle;
        private int error;

        public BorderHelper(Rectangle rectangle, int error)
        {
            this.rectangle = rectangle;
            this.error = error;
        }

        public enum Border
        {
            Top,
            Bottom,
            Left,
            Right,
            Interior,
            Exterior
        }

        public Border getBorder(Point position)
        {
            Border returnVal = Border.Exterior;
            bool borderFound = false;

            bool insideX = false;
            bool insideY = false;

            if (position.X >= rectangle.Left && position.X <= rectangle.Right)
            {
                insideX = true;
            }

            if (position.Y >= rectangle.Top && position.Y <= rectangle.Bottom)
            {
                insideY = true;
            }

            if (insideY)
            {
                if (position.X >= (rectangle.Left - error) && position.X <= (rectangle.Left + error))
                {
                    returnVal = Border.Left;
                    borderFound = true;
                }
                else if (position.X >= (rectangle.Right - error) && position.X <= (rectangle.Right + error))
                {
                    returnVal = Border.Right;
                    borderFound = true;
                }
            }

            if (insideX)
            {
                if (position.Y >= (rectangle.Top - error) && position.Y <= (rectangle.Top + error))
                {
                    returnVal = Border.Top;
                    borderFound = true;
                }
                else if (position.Y >= (rectangle.Bottom - error) && position.Y <= (rectangle.Bottom + error))
                {
                    returnVal = Border.Bottom;
                    borderFound = true;
                }
            }
            
            if (insideX && insideY && !borderFound)
                returnVal = Border.Interior;

            return returnVal;
        }
    }
}
