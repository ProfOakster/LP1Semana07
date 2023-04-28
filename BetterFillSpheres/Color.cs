using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color
    {

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }
        public byte Grey
        {
            get => (byte)((Red + Green + Blue) / 3);
        }
        public string Name
        {
            get
            {
                return this switch
                {
                    { Red: 255, Green: 0, Blue: 0 } => "Red 100%",
                    { Red: 0, Green: 255, Blue: 0 } => "Green 100%",
                    { Red: 0, Green: 0, Blue: 255 } => "Blue 100%",
                    _ => "Mixed"
                };
            }
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }


    }
}