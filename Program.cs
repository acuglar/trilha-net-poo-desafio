using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345678910", modelo: "n1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n---------------------------\n");

Console.WriteLine("Smartphone IPhone: ");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "x", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
