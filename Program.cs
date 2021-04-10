using System;

namespace Task9_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите степень первого многочлена: ");
            int extent1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень второго многочлена: ");
            int extent2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Введите члены первого многочлена: ");
            int[] polynom1 = new int[extent1];
            for (int i = 0; i < extent1; i++)
            {
                polynom1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите члены второго многочлена: ");
            int[] polynom2 = new int[extent2];
            {
                for (int i = 0; i < extent2; i++)
                {
                    polynom2[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Polynom a = new Polynom(polynom1);
            Polynom b = new Polynom(polynom2);
            Polynom c = a + b;
            Console.WriteLine($"({a.ToString()}) + ({b.ToString()}) = {c.ToString()}");

            Console.ReadKey();
        }
    }
}
