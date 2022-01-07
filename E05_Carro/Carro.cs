using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carro
{

    class Carro
    {

        #region Enumerations
        public enum EnumMarca
        {
            Ford,
            Kia,
            Toyota
        }

        public enum EnumModelo
        {
            F1,
            F2,
            K1,
            K2,
            K3,
            T1,
            T2
        }

        public enum EnumCor
        {
            Red,
            Yellow,
            Black,
            Orange,
            Brown
        }
        #endregion

        #region Properties
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Matricula { get; set; }
        public int Cilindrada { get; set; }
        public int Velocidade { get; set; }
        #endregion

        #region Constructors
        public Carro()
        {
            Marca = string.Empty;
            Modelo = string.Empty;
            Cor = string.Empty;
            Matricula = string.Empty;
            Cilindrada = 0;
            Velocidade = 0;
        }

        public Carro(string marca, string modelo, string cor, string matricula, int cilindrada, int velocidade)
        {
            Marca = marca;  // Propriedade = variável
            Modelo = modelo;
            Cor = cor;
            Matricula = matricula;
            Cilindrada = cilindrada;
            Velocidade = velocidade;
        }
        #endregion

        #region Methods
        public void Criar()
        {

            Console.Write("Marca: ");
            Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            Modelo = Console.ReadLine();

            Console.Write("Cor: ");
            Cor = Console.ReadLine();

            Console.Write("Matricula: ");
            Matricula = Console.ReadLine();

            Console.Write("Cilindrada: ");
            Cilindrada = Convert.ToInt16(Console.ReadLine());

            Console.Write("Velocidade: ");
            Velocidade = Convert.ToInt16(Console.ReadLine());

        }

        public void Listar(string titulo)
        {
            Console.Clear();

            Console.WriteLine($"------------------------------\nCARRO {titulo}\n------------------------------\n");

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Cilindrada: {Cilindrada}");
            Console.WriteLine($"Velocidade: {Velocidade}");

            Console.ReadKey();

        }

        public void Parar()
        {

            Velocidade = 0;

        }

        public void Acelerar(int valor)
        {
            Console.WriteLine($"\nAceleração:{Velocidade + valor}");
            
        }

        public void Desacelerar(int valor)
        {
            Console.WriteLine($"\nDesaceleração:{Velocidade - valor}");
        }
        #endregion

        #region Destructor
        ~Carro()
        {
            //GC--> Garbage Coletor
            //para ver a mensagem , executar CTRL+F5
            Console.WriteLine("O carro vai para a sucata");
        }
        #endregion

    }

}
