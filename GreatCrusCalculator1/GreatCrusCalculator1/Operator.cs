using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatCrusCalculator1
{
    internal class Operator
    {
        public double Input1
        {
            get; set;
        }

        public double Input2
        {
            get; set;
        }

        public double Add()
        {
            return Input1 + Input2;
        }

        public double Subtract()
        {
            return Input1 - Input2;
        }

        public double Multiplication()
        {
            return  Input1 * Input2;
        }

        public double Division()
        {
            return Input1 / Input2;
        }

        public double Percentage()
        {
            return Input1 % Input2;
        }


    }
}
