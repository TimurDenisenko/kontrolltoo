using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo
{
    public class U2
    {
        public static bool inarray(string tekst)
        {
            Console.WriteLine("Mis sõna me otsime? ");
            string word = Console.ReadLine(); //получаю слово от пользователя
            tekst= tekst.ToLower(); //весь текст в нижний регистр
            word = word.ToLower();
            if (tekst.Contains(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
