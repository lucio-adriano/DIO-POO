using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarphone Nokia");
Smartphone nokia = new Nokia(numero: "12345689", modelo: "Modelo 1", imei: "11111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarphone iPhone");
Smartphone iPhone = new Iphone(numero: "987654321", modelo: "Modelo 2", imei: "22222222222", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");