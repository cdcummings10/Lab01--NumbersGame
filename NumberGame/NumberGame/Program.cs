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
                Console.WriteLine("Welcome to this Math Numbers Game!");
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
            try
            {
                Console.WriteLine("Enter a number greater than 0.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int[] userArr = new int[userInput];
                int[] fullArr = Populate(userArr);
                int sum = GetSum(fullArr);
                int product = GetProduct(fullArr, sum);
                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your array size = {fullArr.Length}.");
                Console.WriteLine($"Numbers in your array: {String.Join(", ", fullArr)}");
                Console.WriteLine($"The sum of your array = {sum}.");
                int multiplyInput = product / sum;
                Console.WriteLine($"The product of {multiplyInput} * {sum} = {product}.");
                decimal divideInput = product / quotient;
                Console.WriteLine($"The quotient of {product} / {divideInput} = {quotient}.");
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{arr.Length}");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            return arr;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            if (sum < 20)
            {
                throw (new Exception($"Value of {sum} is too low."));
            }
            return sum;
        }

        static int GetProduct(int[] arr, int sum)
        {
            try
            {
                Console.WriteLine($"Please enter a number between 1 and {arr.Length}");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int product = arr[userInput - 1] * sum;

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
