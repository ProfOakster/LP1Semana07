using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        private readonly Color color;
        public string Color
        {
            get => String.Format("{0},{1},{2}", color.Red, color.Green, color.Blue);
        }

        private float radius;
        public float Radius
        {
            get => radius;
        }

        private int throwCount;
        public int ThrowCount
        {
            get => throwCount;
        }

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            throwCount = 0;
        }


        public void Pop()
        {
            radius = 0f;
        }

        public void Throw()
        {
            if (radius > 0f)
            {
                throwCount++;
            }
        }
    }
}