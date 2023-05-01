using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Sea : Vehicle
    {
        //    string type; // As in boat or submarine. Extra credit for making it an enumerator
        public enum Type { boat, submarine }
        protected Type _type;

        //    Constructor(extend base and take type )
        public Sea(string color, Type type) : base(color)
        {
            _type = type;
        }
        //Override ToString( base.ToString() + $" - It is a {_type}" )
        //Ex: Sea - Green - It is a Submarine
        public override string ToString()
        {
            return base.ToString() + $" - It is a {_type}";
        }
    } // class
} // namespace
