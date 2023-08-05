using System;
using System.Numerics;

namespace BigIntMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            string num1Str = Console.ReadLine();

            Console.WriteLine("Digite o segundo número:");
            string num2Str = Console.ReadLine();

            BigInteger num1, num2, result;

            if (BigInteger.TryParse(num1Str, out num1) && BigInteger.TryParse(num2Str, out num2))
            {
                result = BigInteger.Multiply(num1, num2);
                Console.WriteLine($"O resultado da multiplicação é: {result}");
            }
            else
            {
                Console.WriteLine("Os números digitados não são válidos.");
            }
        }
    }
}
