using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Land : Vehicle
    {
        //    int wheels;
        protected int _wheels;

        //    Constructor(extend base to take wheels ) and properties for all
        public Land(string color, int wheels) : base(color)
        {
            _color = color;
            _wheels = wheels;
        }
        public int Wheels { get => _wheels; set => _wheels = value; }

        //    Override ToString( base.ToString() + $" - Number of Wheels {_wheels}; )
        //Ex: Land - Red - Number of Wheels 4
        public override string ToString()
        {
            return base.ToString() + $" - Number of Wheels: {_wheels}";
        }
    } // class
} // namespace
