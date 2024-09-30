using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string color = DEFAULT_COLOR, int x = 0, int y =0, int radius = 0 )
            : base(color, x, y)
        { 
            this.Radius = radius;
        }

        public void Scale(double factor)
        {
            Radius = (int)Math.Round(Radius * factor); // bank round!!!
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle ({X}, {Y}) Radius: {Radius } Color: {Color}");
            // base.Draw();
        }
    }
}
