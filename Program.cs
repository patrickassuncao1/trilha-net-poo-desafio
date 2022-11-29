using POOChallenge.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(number: "123456", model: "Modelo 1", imei: "1111111111", memory: 64);
nokia.Call();
nokia.InstallApplication("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(number: "4987", model: "Modelo 2", imei: "2222222222", memory: 128);
iphone.ReceiveCall();
iphone.InstallApplication("Telegram");