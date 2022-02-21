using System;

namespace ConsoleApp1.ExercicioQuatroListaTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada!");

            Console.Write("Digite um valor inteiro de 1 a 10: ");
            string strValor = Console.ReadLine();
            int valor = Convert.ToInt32(strValor);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", i, valor, i * valor);
            }
        }
    }
}
