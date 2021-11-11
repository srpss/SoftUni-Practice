using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get ; set ; }
        public string Color { get ; set ; }
        public int Battery { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Tesla {Model} with {Battery} Batteries");
            sb.AppendLine(StartUp());
            sb.AppendLine(Stop());
            return sb.ToString().TrimEnd();
        }
        public string StartUp()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
    }
}
