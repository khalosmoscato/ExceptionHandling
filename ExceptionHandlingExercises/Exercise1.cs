using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingExercises
{
    public class Exercise1
    {
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static void DivideUserInputs()
        {
            while (true)
            {
                try
                {
                    int[] input = GetUserInputs();
                    int output = Divide(input[0], input[1]);

                    Console.WriteLine($"The result is: {output}");
                }  
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
        private static int[] GetUserInputs()
        {
            Console.Write("Enter divisor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter dividend: ");
            int num2 = int.Parse(Console.ReadLine());

            int[] userInputs = [num1, num2];

            return userInputs;
        }
    }
}
