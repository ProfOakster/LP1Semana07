using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Color
    {
        private byte red;
        private byte green;

        private byte blue;
        private byte alpha;


        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }
        public byte GetRed() => red;
        public byte GetGreen() => green;
        public byte GetBlue() => blue;
        public byte GetAlpha() => alpha;
        public byte GetGrey() => (byte)((red+green+blue)/3);


        public void SetRed(byte red)
        {
            this.red = red;
        }
        public void SetGreen(byte green)
        {
            this.green = green;
        }
        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }
        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }
    }
}