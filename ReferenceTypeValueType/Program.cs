using System;

namespace ReferenceTypeValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number1 = 10;
            int number2 = 30;

            number1 = number2;

            number2 = 65;

            Console.WriteLine(number1);

            int[] numbers = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 4, 5, 6 };

            numbers = numbers2;

            numbers2[0] = 999;

            Console.WriteLine(numbers[0]);

        }
    }
}
