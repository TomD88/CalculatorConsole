using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class OperatorRequestState : AbstractState
    {
        public override void NextInput(InputConsoleReader input)
        {

            string OperatoreInput;

            Console.WriteLine("Calcolatrice State Pattern");
            Console.WriteLine("Operatori ammessi + * - / ");
            OperatoreInput = this.MyConsoleReadLine();


            if (CheckOperator(OperatoreInput))
            {
                input.Operator = OperatoreInput;

                input.State = new OperandRequestState();

            }

        }


        private bool CheckOperator(string operatore)
        {

            bool FlagOperator = false;

            if (operatore.Equals("+") ||
                operatore.Equals("*") ||
                operatore.Equals("-") ||
                operatore.Equals("/"))
            {
                FlagOperator=true;
            }

            return FlagOperator;
        }

    }
}
