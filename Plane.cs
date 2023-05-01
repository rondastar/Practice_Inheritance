using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Plane : Air
    {
        protected int _numberOfJets;

        //    Constructor(extend base and take type )
        public Plane(string color, int numberOfJets) : base(color)
        {
            _color = color;
            _numberOfJets = numberOfJets;
        }
        public int NumberOfJets { get => _numberOfJets; set => _numberOfJets = value; }

        //Override ToString( base.ToString() + $" - Number of Jets {_numberOfJets}" )
        //Ex: Plane - Pink - Number of Jets 1
        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets: {_numberOfJets}";
        }
    }
}
