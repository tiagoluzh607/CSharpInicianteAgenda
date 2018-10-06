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

            List<string> listaDeNomes = new List<string>();
            string nome = "";


            Console.WriteLine("### Olá meu nome é Sonserina, sua agenda para botar nomes ####\n");

            while (!nome.Equals("sair")) {
                Console.WriteLine("Digite o Nome ");
                nome = Console.ReadLine();
                listaDeNomes.Add(nome);
            }

            Console.WriteLine("Lista de Nomes da Sonserina");

            foreach (string item in listaDeNomes) {
                Console.WriteLine(item);
            }
;

            Console.Read();
        }
    }
}

