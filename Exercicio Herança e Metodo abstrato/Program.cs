using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_Herança_e_Metodo_abstrato.Entities;

namespace Exercicio_Herança_e_Metodo_abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.WriteLine("Enter the number of tax payers" );
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Tax payer #{i} data:" );
                Console.WriteLine("Individual or company (i/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name:" );
                String nome = Console.ReadLine();
                Console.WriteLine("Anual income:");
                double renda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.WriteLine("Health expenditures:");
                    double saude = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, renda, saude));

                }
                else if (ch == 'c')
                {
                    Console.WriteLine("Number of employees:");
                    int p = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, renda, p));

                }
                else {
                    Console.WriteLine("Valor invalido");
                }
                
            }
            double sum = 0.0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (Pessoa tp in list)
            {
                double tax = tp.Taxa();
                Console.WriteLine(tp.Nome + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
