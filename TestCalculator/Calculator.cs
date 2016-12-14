using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class Calculator
    {
        public double Calculate(string operatore, double number1, double number2)
        {

            double rtnValue = 0 ;

            if (operatore.Equals("+"))
            {

                rtnValue = number1 + number2;
            }
            else if(operatore.Equals("-"))
            {

                rtnValue = number1 - number2;
            }
            else if (operatore.Equals("*"))
            {

                rtnValue = number1 * number2;
            }
            else if (operatore.Equals("/"))
            {

                rtnValue = number1 / number2;
            }


            return rtnValue;


        }
    }
}
