using System;
using System.Collections.Generic;
using System.Text;

namespace pag123Book
{
    class Color
    {
        // Declare instances
        private byte colorRed;
        private byte colorGreen;
        private byte colorBlue;
        private byte alpha;

        // auto implemented class properties 
        public byte ColorRed { get; set; }
        public byte ColorGreen { get; set; }
        public byte ColorBlue { get; set; }
        public byte Alpha { get; set; }

        public byte Grayscale => (byte) ((ColorRed + ColorGreen + ColorBlue) / 3);

        // Build Class Constructors
        /// <summary>
        /// Class Constructor that accepts 4 arguments to create color
        /// </summary>
        /// <param name="red"> Color red </param>
        /// <param name="green"> Color green </param>
        /// <param name="blue"> Color blue </param>
        /// <param name="alpha"> Alpha</param>
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            ColorRed = red;
            ColorGreen = green;
            ColorBlue = blue;
            Alpha = alpha;
        }

        /// <summary>
        /// Constructor that accepts 3 arguments that RGB to create grayscales
        /// Where alpha's value is already initialized as 255
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public Color(byte red, byte green, byte blue)
        {
            ColorRed = red;
            ColorGreen = green;
            ColorBlue = blue;
            Alpha = 255;
        }


        /*
        // Get grayscale
        public byte getGrayscale()
        {
            return (byte)((colorRed + colorBlue + colorGreen) / 3);
        }


        // ------------- Long version of writing Properties ------------- //
        // Getters
        public byte getRed() => colorRed;
        public byte getBlue() => colorBlue;
        public byte getGreen() => colorGreen;
        public byte getAlpha() => alpha;

        // Setters
        public void setRed(byte red) { red = colorRed; }
        public void setGreen(byte green) { green = colorGreen; }
        public void setBlue(byte blue) { blue = colorBlue; }
        public void setAlpha(byte alpha) { this.alpha = alpha; }

        */






    }
}
