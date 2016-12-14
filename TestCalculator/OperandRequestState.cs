using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class OperandRequestState : AbstractState
    {


        bool OperandAAssegnato = false;
        bool OperandBAssegnato = false;

        public override void NextInput(InputConsoleReader input)
        {

            GetOperandoAFromInput(input);
            if (OperandAAssegnato)
            {
                GetOperandoBFromInput(input);
            }
            


        }




        private void GetOperandoAFromInput(InputConsoleReader input)
        {
            try
            {
                Console.WriteLine("Inserire l'operando A : ");

                input.Operando1 = double.Parse(this.MyConsoleReadLine());
                OperandAAssegnato = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Errore in inserimento");
                
            }

        }



        private void GetOperandoBFromInput(InputConsoleReader input)
        {
            try
            {
                Console.WriteLine("Inserire l'operando B : ");

                input.Operando2 = double.Parse(this.MyConsoleReadLine());
                OperandBAssegnato = true;

                input.State= new ComputeState();
            }
            catch (Exception)
            {
                Console.WriteLine("Errore inn inserimento");
                
            }

        }




    }
}
