using System;

namespace D10_Metodos
{

    class Program
    {

        static void Main(string[] args)
        {

            Methods method01 = new Methods();

            /*
            method01.VoidMethod();
            Console.WriteLine(method01.NoVoidMethod());
            */

            method01.Calcular01();

            Console.WriteLine(method01.Calcular02());

            Console.ReadKey();

        }

    }

}
