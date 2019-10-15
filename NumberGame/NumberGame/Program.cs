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
        /// <summary>
        /// Runs the main Numbers Game program. Runs all the calculation functions and writes to
        /// console the results of the calculations.
        /// </summary>
        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than 0.");
                string userInput = Console.ReadLine();
                int[] userArr = new int[Convert.ToInt32(userInput)];
                int[] fullArr = Populate(userArr);
                int sum = GetSum(fullArr);
                int product = GetProduct(fullArr, sum);
                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your array size = {fullArr.Length}.");
                Console.WriteLine($"Numbers in your array: {String.Join(", ", fullArr)}");
                Console.WriteLine($"The sum of your array = {sum}.");
                //Backwards calculates input for product
                int multiplyInput = product / sum;
                Console.WriteLine($"The product of {multiplyInput} * {sum} = {product}.");
                //Backwards calculates input for quotient
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
        /// <summary>
        /// Takes in an integer array and updates array with values inputted by the user.
        /// </summary>
        /// <param name="arr">Takes in an integer array</param>
        /// <returns>Returns a populated integer array.</returns>
        static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{arr.Length}");
                string input = Console.ReadLine();
                arr[i] = Convert.ToInt32(input);

            }
            return arr;
        }
        /// <summary>
        /// Takes an integer array and calculates the sum of the the array. Throw an exception if the sum is less than 20.
        /// </summary>
        /// <param name="arr">Takes an integer array.</param>
        /// <returns>Returns an integer sum of the values of the array.</returns>
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
        /// <summary>
        /// Takes in an integer array and an integer. Takes user input to choose specific index of array.
        /// Returns user targeted index value * the integer parameter.
        /// </summary>
        /// <param name="arr">Takes in an integer array.</param>
        /// <param name="sum">Takes in an integer (Preferably the sum of the array)</param>
        /// <returns>Returns the product as an integer.</returns>
        static int GetProduct(int[] arr, int sum)
        {
            try
            {
                Console.WriteLine($"Please enter a number between 1 and {arr.Length}");
                string userInput = Console.ReadLine();
                int product = arr[Convert.ToInt32(userInput) - 1] * sum;

                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Takes in an integer and prompts the user for an integer. Divides the argument integer
        /// by the user prompted integer. Returns the quotient.
        /// </summary>
        /// <param name="product">Takes in an integer (preferably the product from GetProduct())</param>
        /// <returns>Returns a decimal.</returns>
        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a number to divide {product} by:");
                string userInput = Console.ReadLine();
                decimal quotient = Decimal.Divide(product, Convert.ToInt32(userInput));
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
