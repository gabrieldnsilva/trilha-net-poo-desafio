using System.Security.Cryptography;
using DesafioPOO.Models;

Console.WriteLine("Iniciando os testes com o dispositivo " + nameof(Nokia));

Nokia meuNokia = new Nokia("");

Console.WriteLine($"Número: {meuNokia.Numero}");
Console.WriteLine($"Modelo: {meuNokia.Modelo}");
Console.WriteLine($"IMEI: {meuNokia.IMEI}");
Console.WriteLine($"Armazenamento: {meuNokia.Memoria} GB");

meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Iphone meuIphone =  new Iphone("");

Console.WriteLine($"Número: {meuIphone.Numero}");
Console.WriteLine($"Modelo: {meuIphone.Modelo}");
Console.WriteLine($"IMEI: {meuIphone.IMEI}");
Console.WriteLine($"Armazenamento: {meuIphone.Memoria} GB");

meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("WhatsApp");