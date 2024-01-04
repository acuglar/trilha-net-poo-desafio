using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "n1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("---------------------------\n");

Console.WriteLine("Smartphone IPhone: ");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "x", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
