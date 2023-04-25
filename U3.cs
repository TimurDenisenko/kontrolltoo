using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo
{
    public class U3
    {
        public static int[,] saal()
        {
            int n1 = 0;
            int n2 = 0;
            do
            {
                Console.WriteLine("Mitu rida?");
                n1=int.Parse(Console.ReadLine());
            } while (n1==0);
            do
            {
                Console.WriteLine("Mitu kohta?");
                n2= int.Parse(Console.ReadLine());
            } while (n2==0);
            int[,] saal = new int[n1,n2];
            Random rnd = new Random();
            for (int i = 0; i < n1; i++)
            {
                for (int o = 0; o < n2; o++)
                {
                    saal[i, o]=rnd.Next(0, 2);
                }
            }
            return saal; //заполнил места в зале через рандом
        }


        public static int[,] getkoht(int[,] saal)
        {
            Console.WriteLine("Kirjutage rida ja koht (R/K)");
            string koht = Console.ReadLine(); //узнаю желаемое место у пользователя
            string[] arrkoht = koht.Split("/"); //добавляю эти значения в список
            int r = Convert.ToInt32(arrkoht[0])-1;
            int k = Convert.ToInt32(arrkoht[1])-1; //Конвертирую в числовое значения для будущего использования и отнимаю 1
                                                   //т.к. пользователь не будет писать например 0/0
            if (saal[r,k]==0) //проверяю свободно ли это место
            {
                Console.WriteLine("Sa võtsid selle koha");
                saal[r,k]=1; // если свободно то пишу об этом и занимаю для пользователя
            }
            else
            {
                Console.WriteLine("See koht ei ole vaba");
                getkoht(saal); // если не свободно то запускаю по новому функцию/метод
            }
            return saal;
        }
    }
}
