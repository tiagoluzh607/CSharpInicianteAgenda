using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPet
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome1;
            string nome2;
            string nome3;

            Console.WriteLine("### Olá meu nome é Sonserina, sua agenda para botar nomes ####\n");

            Console.WriteLine("Digite o Nome ");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o Nome ");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite o Nome ");
            nome3 = Console.ReadLine();

            Console.WriteLine("Lista de Nomes da Sonserina");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);


            Console.Read();
        }
    }
}

