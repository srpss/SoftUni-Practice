using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Seat : ICar
    {
        public Seat(string modell, string color)
        {
            Model = modell;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Seat {Model}");
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
