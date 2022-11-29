using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOChallenge.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory) { }

        public override void InstallApplication(string name)
        {
            Console.WriteLine($"Instalando o aplicativo \"{name}\" no Nokia ");
        }
    }
}