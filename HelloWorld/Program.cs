using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fakultät
            int[] fak = new int[7];
            int seven = 7;

            for (int i = 0; i < seven; i++)
            {
                fak[i] = i + 1;
            }

            int fakultat = 1;
            foreach (int i in fak)
            {
                fakultat *= i;
            }

            Console.WriteLine("7! = {0}", fakultat);

            //Fibonacci
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);

            while (list.Count < 8)
            {
                int last = list.Last();
                int lastlast = list[list.Count - 2];
                list.Add(last + lastlast);
            }

            string fibonacci = "Fibonacci Folge bis 13: ";
            foreach (int i in list)
            {
                fibonacci = fibonacci + i + ",";
            }
            Console.WriteLine(fibonacci);

            static int gebeMaxAus(int int1, int int2, int int3)
            {
                if (int1 > int2)
                {
                    if (int1 > int3)
                    {
                        return int1;
                    } else
                    {
                        return int3;
                    }
                } else
                {
                    if (int2 > int3)
                    {
                        return int2;
                    }
                    else
                    {
                        return int3;
                    }
                }
            }

            Console.WriteLine("Grösste Zahl: {0}", gebeMaxAus(12, 34, 11));

            static void gebeNullBisHunderAus()
            {
                int iterator = 0;
                while (iterator <= 100)
                {
                    Console.WriteLine("Iterator: {0}", iterator);
                    iterator++;
                }
            }
            gebeNullBisHunderAus();
        }
    }
}