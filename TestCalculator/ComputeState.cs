using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class ComputeState : IState
    {
        public void NextInput(InputConsoleReader input)
        {


            double operando1 = input.Operando1;
            double operando2 = input.Operando2;
            double result = 0;
            string operatore = input.Operator;
            
            
            Console.WriteLine("Sono pronto per fare il calcolo");

            Calculator c = new Calculator();

            result=c.Calculate(operatore, operando1, operando2);
            Console.WriteLine("Il risultato è " + result);
            Console.ReadLine();

            input.State = new OperatorRequestState();
        }
    }
}
