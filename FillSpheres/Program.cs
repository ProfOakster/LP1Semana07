using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color purple = new Color(200, 0, 200);
            Color orange = new Color(200, 200, 0);
            Color yellow = new Color(0, 200, 200);


            Sphere ball1 = new Sphere(purple, 3.3f);
            Sphere ball2 = new Sphere(orange, 2.9f);
            Sphere ball3 = new Sphere(yellow, 8.6f);

            ball3.Throw();
            ball3.Throw();
            ball2.Throw();
            ball2.Pop();
            ball1.Pop();
            ball1.Throw();

            Console.WriteLine("{0};{1};{2}", ball1.GetColor(), ball1.GetRadius(), ball1.GetTimesThrown());
            Console.WriteLine("{0};{1};{2}", ball2.GetColor(), ball2.GetRadius(), ball2.GetTimesThrown());
            Console.WriteLine("{0};{1};{2}", ball3.GetColor(), ball3.GetRadius(), ball3.GetTimesThrown());


        }






    }
}
