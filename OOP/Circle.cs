using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle : Shape, IScaleable
    {
        //[JsonInclude]
        [JsonIgnore]
        public string MyData { get; set; } = "abc";

        public int Radius { get; set; }

        public Circle(string color = DEFAULT_COLOR, int x = 0, int y =0, int radius = 0 )
            : base(x, y, color)
        { 
            this.Radius = radius;
        }

        
        // implicit implementation
        public void Scale(double factor)
        {
            Radius = (int)Math.Round(Radius * factor); // bank round!!!
        }

        /*
        // explicit implementation
        void IScaleable.Scale(double factor)
        {
            Radius = (int)Math.Round(Radius * factor); // bank round!!!
        }*/

        /*
        void IScaleable.DefaultDoubleScale()
        {
            this.Scale(IScaleable.DEFAULT_FACTOR * 3);
        }*/

        public override void Draw()
        {
            Console.WriteLine($"Circle ({X}, {Y}) Radius: {Radius } Color: {Color}");
            // base.Draw();
        }

        public override string ToString()
        {
            return $"Circle ({X}, {Y}) Radius: {Radius} Color: {Color}";
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType() == this.GetType()) 
            { 
                Circle c = (Circle)obj;
                return Color == c.Color && X == c.X && Y == c.Y && Radius == c.Radius;
            }
            //if (obj is Circle c) 
            //{ 
            //    return Color == c.Color && X == c.X && Y == c.Y && Radius == c.Radius;
            //}
            
            
            return base.Equals(obj);
        }

        public override int GetHashCode() => HashCode.Combine(X, Y, Radius, Color);
    }
}
