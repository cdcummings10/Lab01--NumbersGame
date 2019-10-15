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
            Console.ReadLine();
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
            return sum;
        }

        static int GetProduct(int[] arr, int sum)
        {
            try
            {
            Console.WriteLine($"Please enter a number between 1 and {arr.Length}");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int product = arr[userInput] * sum;
            return product;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static void GetQuotient() { }
    }
}
