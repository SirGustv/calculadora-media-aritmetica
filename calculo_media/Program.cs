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

            Media = ((Nota1 * 2) + (Nota2 * 3) + (Nota3 * 4) + (Nota4 * 1)) / 10;
            Console.WriteLine("Sua média é "+ Media.ToString("0.0"));

            if (Media >= 7)
            {
                Console.WriteLine("Parabéns " + Name + ", você passou de ano!");
            }
            else if (Media < 5)
            {
                Console.WriteLine("Você foi reprovado!");
            }
            else if (Media >= 5 && Media < 7)
            {
                Console.WriteLine("Aluno em exame");
                Console.WriteLine("Insira a nota do exame: ");

                decimal NExame = Convert.ToDecimal(Console.ReadLine());
                Media = (Media + NExame) / 2;

                if (Media >= 5)
                {
                    Console.WriteLine(Name + " você foi aprovado. Sua média final é " + Media.ToString("0.0"));
                }
                else
                {
                    Console.WriteLine(Name + " você foi reprovado. Sua média final é " + Media.ToString("0.0"));
                }

            }

        }
    }
}
