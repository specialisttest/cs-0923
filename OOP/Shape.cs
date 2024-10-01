using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public /*sealed*/ abstract class Shape //: System.Object // object
    {
        public const string DEFAULT_COLOR = "black";

        public virtual string Color { get; set; }
        public int X { get; set; }

        public int Y { get; set; }

        public Shape(string color = DEFAULT_COLOR, int x = 0, int y = 0)
        {
            Color = color;
            X = x;
            Y = y;
        }

        public abstract void Draw();

        /*public virtual void Draw()
        { 
            Console.WriteLine($"Shape ({X}, {Y}) Color: {Color}");
        }*/
    }
}
