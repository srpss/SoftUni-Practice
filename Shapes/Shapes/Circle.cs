using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public int radius { get; set; }
        public void Draw()
        {
            double rIn = this.radius - 04;
            double r0ut = this.radius + 0.4;
            for (double y = this.radius; y >= -this.radius; --y)
            {
                
                for (double x = -this.radius; x < r0ut ; x+=0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= r0ut * r0ut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            //string top = new String(' ', radius);
            //string topMid = new string('*', radius * 2 + 1);
            //Console.WriteLine($"{top}{topMid}{top}");
            //for (int i = 0; i < radius-1; i++)
            //{
            //    Console.WriteLine();
            //}
            //string spaces = String.Concat(Enumerable.Repeat(" ", radius * 3));              
            //Console.WriteLine($"*{spaces}*");
            //Console.WriteLine($"{top}{topMid}{top}");
        }
    }
}
