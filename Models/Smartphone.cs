namespace POOChallenge.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        protected string _model;
        protected string _imei;
        protected int _memory;

        public Smartphone(string number, string model, string imei, int memory)
        {
            this.Number = number;
            this._model = model;
            this._imei = imei;
            this._memory = memory;
        }

        public void Call()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstallApplication(string name);

    }
}