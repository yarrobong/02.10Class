using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._10Class
{
    internal class Program1
    {
        static void Main()
        {
            Console.Write("Введите число из нескольких цифр: ");
            string n1 = Console.ReadLine();
            Console.Write("Введите цифру: ");
            string n2 = Console.ReadLine();
            bool hasN1 = n1.Contains(n2);
            if (hasN1 == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            int indexN1 = n1.IndexOf(n2);
            Console.WriteLine(indexN1);

            



            //2  ДОДЕЛАИТ
            Console.Write("Введите первую сторону: ");
            string q1 = Console.ReadLine();
            if (!string.IsNullOrEmpty(q1))
            {
                Console.Write("Введите вторую сторону: ");
                string q2 = Console.ReadLine();
                if (!string.IsNullOrEmpty(q2));
                {
                    if (Double.TryParse(q1.Replace(",", "."), out double side1) &&
                        Double.TryParse(q2.Replace(",", "."), out double side2))
                    {
                        double area = side1 * side2;
                        Console.WriteLine($"Площадь: {area}");
                    }
                    else
                    {
                        Console.WriteLine("Введите корректные числа");
                    }
                }
            }




            //3
            Console.WriteLine("Введиет стороны прямоугольника через пробел");

            string p = Console.ReadLine();
















            Console.ReadKey();
        }
    }
}