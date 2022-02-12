using System;

namespace Task1
{
    class Program
    {
        static double Square(int length)
        {
            return (length * 4);
        }
        static double Square(int length, int width)
        {
            return (length * 2) + (width * 2);
        }

        static double Degree(double x, int n)
        {
            if (n > 0)
            {
                double tempX = x;
                for (int i = 1; i < n; i++)
                {
                    tempX *= x;
                }
                return tempX;
            }
            if (n == 0)
                return 1;
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Квадрат по 1 стороне: length = 4");
            Console.WriteLine(Square(4));
            Console.WriteLine();
            Console.WriteLine("Квадрат по 1 стороне: length = 4, width = 5");
            Console.WriteLine(Square(4, 5));
            Console.WriteLine();
            Console.WriteLine("Степень. 2 в 5");
            Console.WriteLine(Degree(2,5));
            Console.WriteLine();
            Console.WriteLine("Степень. 4 в 0");
            Console.WriteLine(Degree(4, 0));
            Console.WriteLine();
            Console.WriteLine("Степень. 30 в -100");
            Console.WriteLine(Degree(30, -100));
        }

        static void GAbiturient()
        {
            Abiturient abiturient = new Abiturient();
            abiturient.FullName1 = "";
        }

        static void Abiturient(string FullName, int Klass, double AVG)
        {

        }
    }
}
