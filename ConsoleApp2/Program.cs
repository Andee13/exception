using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int i;
            try
            {
                for (i = 0; i <= 9; i++)
                {
                    Console.WriteLine(myArray[i]);
                }

                myArray[3] = int.Parse(Console.ReadLine());
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception: Вихід за межі діапазону");
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception: Format isn't right");
            }
        }

    }
}