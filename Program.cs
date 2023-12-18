using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando a classe Nokia
            Nokia nokia = new Nokia("123456789", "Nokia XYZ", "ABCDEF123456", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Testando a classe Iphone
            Iphone iphone = new Iphone("987654321", "iPhone 12", "ZYXWVU654321", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine(); // Para manter a janela aberta até que o usuário pressione Enter
        }
    }
}
