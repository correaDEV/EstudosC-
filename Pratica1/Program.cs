using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "João";
            int idade = 19;
            float altura = 1.75f;
            bool masculino = true;  

            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}, Masculino: {masculino}");

        }
    }
}
