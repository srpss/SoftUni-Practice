using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string StartUp();
        public string Stop();
    }
}
