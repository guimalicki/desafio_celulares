// See https://aka.ms/new-console-template for more information

//Criando os celulares
using desafio_celulares.Models;

Nokia nokia = new Nokia("182391232", "Tijolão", "12233213231", "8");
Iphone iphone = new Iphone("1234555521", "Iphone 15 Pro", "1234834727313", "256");
string app = "WhatsApp";

string risco = "-----------------------------------------------------";

Console.WriteLine(risco);
Console.WriteLine($"Testes do {iphone.Modelo}");
Console.WriteLine("Tentativa de ligar");
if (iphone.Ligar())
{
    Console.WriteLine("Ligação concluída");
}
else
{
    throw new Exception("Falha na ligação!");
}
Console.WriteLine("\nTentativa de receber ligação");
if (iphone.ReceberLigacao())
{
    Console.WriteLine("Ligação recebida!");
}
else
{
    throw new Exception("Problema ao receber ligação");
}

Console.Write($"\nTentativa de instalar o {app}\n");
iphone.InstalarAplicativo(app);

Console.WriteLine(risco);

Console.WriteLine($"Testes do {nokia.Modelo}\n");
Console.WriteLine("Tentativa de ligar");
if (nokia.Ligar())
{
    Console.WriteLine("Ligação concluída");
}
else
{
    throw new Exception("Falha na ligação!");
}
Console.WriteLine("\nTentativa de receber ligação");
if (nokia.ReceberLigacao())
{
    Console.WriteLine("Ligação recebida!");
}
else
{
    throw new Exception("Problema ao receber ligação");
}

Console.Write($"\nTentativa de instalar o {app}\n");
nokia.InstalarAplicativo(app);

Console.WriteLine(risco);
Console.WriteLine("FIM DOS TESTES");