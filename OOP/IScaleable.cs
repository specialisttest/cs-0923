using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace OOP
{
    // C++ - pure abstract class: no fields, no methods implementation
    public interface IScaleable
    {
        // public abstract 
        void Scale(double factor);

        // public virtual
        void DefaultDoubleScale()
        {
            this.Scale(DEFAULT_FACTOR * 2);
        }


        public const double DEFAULT_FACTOR = 2;
        public static double FactorZero = 1;


        public static void Scale(Shape[] shapes, double factor = DEFAULT_FACTOR)
        {
            if (factor == 0.0) factor = FactorZero;
            foreach (Shape shape in shapes)
                if (shape is IScaleable scale) // scale = (IScaleable)shape
                    scale.Scale(factor);
        }
    }

    public interface ICoords
    {
        int X { get; }
        int Y { get; }
    }
}
