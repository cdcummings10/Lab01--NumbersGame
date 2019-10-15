using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program has finished running");
                Console.ReadLine();
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than 0.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int[] userArr = new int[userInput];
            int[] fullArr = Populate(userArr);
            int sum = GetSum(fullArr);
            int product = GetProduct(fullArr, sum);
            decimal quotient = GetQuotient(product);
        }

        static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{arr.Length}");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"Your array size = {arr.Length}.");
            return arr;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"The sum of your array = {sum}.");
            return sum;
        }

        static int GetProduct(int[] arr, int sum)
        {
            try
            {
                Console.WriteLine($"Please enter a number between 1 and {arr.Length}");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int product = arr[userInput - 1] * sum;
                Console.WriteLine($"The product of {arr[userInput - 1]} * {sum} = {product}.");
                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }

        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a number to divide {product} by:");
                int userInput = Convert.ToInt32(Console.ReadLine());
                decimal quotient = Decimal.Divide(product, userInput);
                Console.WriteLine($"The quotient of {product} * {userInput} = {quotient}.");
                return quotient;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
