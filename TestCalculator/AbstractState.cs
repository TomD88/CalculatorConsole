using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    abstract class AbstractState : IState
    {
        public abstract void NextInput(InputConsoleReader input);
        protected string MyConsoleReadLine()
        {
            string car = Console.ReadLine();

            if (car.Equals("c"))
            {
                Console.WriteLine("Richiesta uscita dal programma...");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            return car ;
        }
    }
}
