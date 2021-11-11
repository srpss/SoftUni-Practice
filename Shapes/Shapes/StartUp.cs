using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //https://softuni.bg/trainings/resources/officedocument/66149/interfaces-and-abstraction-lab-csharp-oop-october-2021/3484
            //_1_();
            _2_();
        }

        private static void _2_()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());

        }

        private static void _1_()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            circle.Draw();
            rect.Draw();

        }
    }
}
