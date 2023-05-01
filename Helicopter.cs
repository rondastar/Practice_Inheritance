using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    //    int _numberOfPropellers;
    //    Constructor(extend base and take type )
    //Override ToString( base.ToString() + $" - Number of Propellers{_numberOfPropellers}" )
    //Ex: Helicopter - Orange - Number of Propellers 2
    internal class Helicopter : Air
    {
        protected int _numberOfPropellers;

        public Helicopter(string color, int numberOfPropellers) : base(color)
        {
            _color = color;
            _numberOfPropellers = numberOfPropellers;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Number of Propellers: {_numberOfPropellers}";
        }
    }
}
