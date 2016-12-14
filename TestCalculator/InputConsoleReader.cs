namespace TestCalculator
{
    class InputConsoleReader
    {

        private double _Operando1;
        private double _Operando2;
        private string _Operator;



        public IState State { get; set; }

        internal double Operando1
        {
            get
            {
                return _Operando1;
            }

            set
            {
                _Operando1 = value;
            }
        }

        internal double Operando2
        {
            get
            {
                return _Operando2;
            }

            set
            {
                _Operando2 = value;
            }
        }

        internal string Operator
        {
            get
            {
                return _Operator;
            }

            set
            {
                _Operator = value;
            }
        }

        public InputConsoleReader()
        {
            State = new OperatorRequestState();
        }




        public void NextInput()
        {

            State.NextInput(this);

        }

    }
}