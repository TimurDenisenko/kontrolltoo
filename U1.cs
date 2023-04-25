using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo
{
    public class U1
    {
        public static int[,] inarray()
        {
            Random rnd = new Random();
            int n1 = 0;
            int n2 = 0;
            do
            {
                Console.WriteLine("Väljade arv");
                n1 = int.Parse(Console.ReadLine());
            } while (n1==0);
            do
            {
                Console.WriteLine("Kirjete arv (paarisarv)");
                n2 = int.Parse(Console.ReadLine());
            } while (n2%2!=0 || n2==0);

            int[,] sosedi = new int[n1, n2];
            for (int i = 0; i < n1; i++)
            {
                for (int o = 0; o < n2; o++)
                {
                    sosedi[i, o]=rnd.Next(10, 100); //заполняю двухмерный массив
                }
            }
            return sosedi;
        }

        public static int[,] newarray(int[,] sosedi)
        {
            int n1 = sosedi.GetLength(0);
            int n2 = sosedi.GetLength(1);
            int[,] newsosedi = new int[4, 10];
            for (int i = 0; i < n1; i++)
            {
                for (int o = 0; o < n2; o++)
                {
                    if (o%2==0)
                    {
                        newsosedi[i, o] = sosedi[i, o+1];
                    }
                    else
                    {
                        newsosedi[i, o] = sosedi[i, o-1];
                    }
                } //переставляю парные строки в массиве
            }
            return newsosedi;
        }
    }
}
