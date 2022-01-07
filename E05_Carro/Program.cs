using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carro
{

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Carro carro01 = new Carro();    // carro vazio

                carro01.Criar();
                carro01.Listar("1");
                carro01.Acelerar(10);
                carro01.Desacelerar(5);

                Console.ReadKey();

                Carro carro02 = new Carro("a", "b", "c", "aa", 1000, 100);//construtor:carro com valores

                carro02.Listar("2");
                carro02.Acelerar(10);
                carro02.Desacelerar(5);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nErro!");
                Console.WriteLine($"({ex.Message})");

                Console.ReadKey();
            }

            Console.ReadKey();

        }

    }

}
