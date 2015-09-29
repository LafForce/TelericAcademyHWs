using System;

namespace GSM
{
    //display characteristics (size and number of colors
    class Display
    {
        private float? displaySize = null;
        private int? numberOfColors = null;

        public Display()
        {
        }

        public Display(float displaySize, int numberOfColors)
        {
            this.DisplaySize = displaySize;
            this.NumberOfColors = numberOfColors;
        }

        //        Problem 5. Properties
        public float? DisplaySize
        {
            get
            {
                return this.displaySize;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Negative dimmensions, boy sure this is a new technology!");

                }
                this.displaySize = value;
            }
        }
        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("If this display has just one color, then why it is called display?");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return String.Format(@"a {0} inch display,
it shows {1} colors."
                , DisplaySize, NumberOfColors);
        }
    }
}