using System;

namespace ProdutoDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números para a multiplicação: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            Produto(x, y);
        }
        public static int Produto(int num1, int num2)
        {
            int result = num1 * num2;

            Console.WriteLine("O resultado da multiplicação =  {0}", result);

            return result;

        }
    }
}
