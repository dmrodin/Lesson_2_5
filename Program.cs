using System;

namespace Lesson_2_5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");

            double value = Convert.ToDouble(Console.ReadLine());

            bool result = value == (int)value;
            
            Console.WriteLine(result);
        }
    }
}
