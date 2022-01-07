using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_Colecoes
{

    class Program
    {

        static void Main(string[] args)
        {

            #region ArrayList: inteiros

            //1.Instanciar
            ArrayList listaNumeros = new ArrayList();

            //2.Adicionar valores com o metodo Add
            listaNumeros.Add(100);
            listaNumeros.Add(2);
            listaNumeros.Add(-3);
            listaNumeros.Add(-42);

            //3.Adicionar com For
            for (int i = 5; i < 11; i++)
            {
                listaNumeros.Add(i);
            }

            //500-520, incremento de 2
            for (int i = 500; i < 521; i = i + 2)
            {
                listaNumeros.Add(i);
            }

            //4.Listar com Foreach
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadKey();
            Console.Clear();

            #region ArrayList: strings
            //1.Instanciar e adicionar valores

            ArrayList listaStrings = new ArrayList()
            {
                "a",
                "b",
                "c",
                "d"
            };

            //2.Adicionar valores com o metodo Add
            listaStrings.Add("C#");
            listaStrings.Add("Microsoft");

            //3.Adicionar valores pela consola
            Console.Write("Novastring: ");
            listaStrings.Add(Console.ReadLine());

            //4.Listar
            foreach (String item in listaStrings)
            {
                Console.WriteLine(listaStrings);
            }

            #endregion

            #region ArrayList:pessoas
            ArrayList listaPessoas = new ArrayList();

            Person person01 = new Person();
            Person person02 = new Person();

            person01.Name = "Pessoa 1";
            person01.Location = "Rua 1";

            person02.Name = "Pessoa 2";
            person02.Location = "Rua 2 ";

            listaPessoas.Add(person01);
            listaPessoas.Add(person02);

            foreach (Person item in listaPessoas)
            {
                Console.WriteLine($"{item.Name} mora em {item.Location}");
            }
            #endregion

            #region Arraylist: funcionarios
            ArrayList listaEmployees = new ArrayList();

            Employee employee01 = new Employee();
            Employee employee02 = new Employee();

            employee01.Name = "";
            employee01.Location = "";
            employee01.Department = "";

            employee02.Name = "";
            employee02.Location = "";
            employee02.Department = "";

            listaEmployees.Add(employee01);
            listaEmployees.Add(employee02);

            foreach (Employee item in listaEmployees)
            {
                Console.WriteLine($"{item.Name} mora em {item.Location} e trabalha no departamento {item.Department}.");
            }
            #endregion

            #region Generic List
            List<int> listNumbers = new List<int>()
            {
                1,
                2,
                3
            };
            listNumbers.Add(4);
            #endregion
        }

    }

}
