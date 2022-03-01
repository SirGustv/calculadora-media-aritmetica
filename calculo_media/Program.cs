using System;

namespace calculo_media
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Name;
            decimal Nota1, Nota2, Nota3, Nota4, Media;
            //variáveis

            Console.Write("Insira seu nome: ");
            Name = Console.ReadLine();
            Console.WriteLine("Bem Vindo " + Name + " ao Sistema de notas.");

            Console.WriteLine("Insira suas notas.\nNota 1: ");
            Nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            Nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            Nota3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Nota 4: ");
            Nota4 = Convert.ToDecimal(Console.ReadLine());

            Media = (Nota1 + Nota2 + Nota3 + Nota4)/ 4;

            Console.WriteLine("Sua média é "+ Media);

        }
    }
}
