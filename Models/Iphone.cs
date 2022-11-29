namespace POOChallenge.Models
{
    public class Iphone : Smartphone
    {

        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory) { }

        public override void InstallApplication(string name)
        {
            Console.WriteLine($"Instalando o aplicativo \"{name}\" no Iphone ");
        }
    }
}