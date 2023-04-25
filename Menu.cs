using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("7. Variant\n\nÜ 1.");
            int[,] sosedi= U1.inarray(); //Получаю двухмерный массив
            int n1 = sosedi.GetLength(0);
            int n2 = sosedi.GetLength(1);
            for (int i = 0; i < n1; i++)
            {
                for (int o = 0; o < n2; o++)
                {
                    Console.Write("{0} ",sosedi[i,o]); //Вывожу двухмерный массив на экран
                }
                Console.WriteLine();
            }
            sosedi = U1.newarray(sosedi); //получаю новый двухмерный массив
            Console.WriteLine();

            for (int i = 0; i < n1; i++)
            {
                for (int o = 0; o < n2; o++)
                {
                    Console.Write("{0} ", sosedi[i, o]); //Вывожу новый двухмерный массив на экран
                }
                Console.WriteLine();
            }



            Console.WriteLine("\nÜ 2.");
            string tekst = "At vero eos et accusamus et iusto odio dignissimos ducimus, quia voluptas sit, aspernatur aut odit aut fugit,\nsed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est,\nfacere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Lorem ipsum dolor sit amet,\nconsectetur adipiscing elit,...";
            Console.WriteLine(tekst);
            bool tf = U2.inarray(tekst); //получаю истинну или ложь в зависимости от содержания или не содержания слова в тексте 
            if (tf)
            {
                Console.WriteLine("See sõna on olemas");
            }
            else
            {
                Console.WriteLine("Seda sõna ei ole");
            }



            Console.WriteLine("\nÜ 3.");
            int[,] saal = U3.saal(); //создаю кинотеаторный зал
            n1 = saal.GetLength(0);
            n2 = saal.GetLength(1);
            for (int i = 0; i < n1; i++)
            {
                for (int o = 0; o < n2; o++)
                {
                    Console.Write("{0} ", saal[i, o]); //Вывожу новый двухмерный массив на экран
                }
                Console.WriteLine();
            }
            saal = U3.getkoht(saal); //Пользователь занимает место в зале
            for (int i = 0; i < n1; i++)
            {
                for (int o = 0; o < n2; o++)
                {
                    Console.Write("{0} ", saal[i, o]); //Вывожу новый двухмерный массив на экран
                }
                Console.WriteLine();
            }

        }
    }
}
