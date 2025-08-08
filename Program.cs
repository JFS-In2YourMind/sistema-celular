using SistemaCelular.Models;

Nokia nokia = new Nokia(numero: "123456", modelo: "Nokia Tijolão", imei: "111111111", memoria: 64);
Console.WriteLine($"Smartphone Nokia: {nokia.Modelo}, Memória: {nokia.Memoria}GB");
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine();

Iphone iphone = new Iphone(numero: "654321", modelo: "iPhone 15", imei: "222222222", memoria: 128);
Console.WriteLine($"Smartphone iPhone: {iphone.Modelo}, Memória: {iphone.Memoria}GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
