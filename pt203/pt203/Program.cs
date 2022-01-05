using System;
using System.Collections.Generic;

namespace pt203
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbas = new List<int>() { 2, 4, 8, 16 };
                Console.WriteLine("Pick a number to divide the list of integers by");
                int divSelect = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbas)
                {
                    int result = number / divSelect;
                    Console.WriteLine(result);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't destroy the universe by dividing by 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("program has emerged from try/catch block");
                Console.ReadLine();
            }
        }
    }
}
