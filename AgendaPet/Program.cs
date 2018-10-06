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

            adicionaPessoaNaLista(listaDeNomes, nome);

            exibeAgenda(listaDeNomes);


            Console.Read();
        }




        private static string adicionaPessoaNaLista(List<string> listaDeNomes, string nome)
        {
            while (!nome.Equals("sair"))
            {
                Console.WriteLine("Digite o Nome ");
                nome = Console.ReadLine();
                listaDeNomes.Add(nome);
            }

            return nome;
        }

        private static void exibeAgenda(List<string> listaDeNomes)
        {
            Console.WriteLine("\n\nLista de Nomes da Sonserina");

            foreach (string item in listaDeNomes)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------");
            }
        }




    }
}

