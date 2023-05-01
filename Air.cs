using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Air : Vehicle
    {
        //Class Air takes no additional information
        public Air(string color) : base(color)
        {
            _color = color;
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
