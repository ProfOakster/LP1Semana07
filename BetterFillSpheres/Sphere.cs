using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float radius;
        private int throwCount;

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            throwCount = 0;
        }
        public string GetColor() =>  String.Format("{0},{1},{2}",color.GetRed(), color.GetGreen(), color.GetBlue());
        public float GetRadius() => radius;
        public int GetTimesThrown() => throwCount;

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