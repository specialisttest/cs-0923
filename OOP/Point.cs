using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Point : Shape
    {

        public Point(int x = 0, int y =0, string color = DEFAULT_COLOR)
            : base(x, y, color)
        { }

        public override void Draw()
        {
            Console.WriteLine($"Point ({X}, {Y}) Color: {Color}");
        }
    }
}
