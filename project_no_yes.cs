using System;

namespace ConsoleAppInnaVIG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    namespace ConsoleAppInnaVG
    {
        class Program
        {
            static void Main(string[] args)
            { //числовые параметры
                int N = 5;
                int[] myStringArray = new int[5] { 1, 1 , 4, 1, 1 };
                int M = 4;

                //перевод чистловых параметров в строковые
                string str = "";
                str = myStringArray[0].ToString() + myStringArray[1].ToString() + myStringArray[2].ToString() + myStringArray[3].ToString() + myStringArray[4].ToString();
              
                string Mstr = M.ToString();
                //Обрезанная строка
                string str_new = str.Substring(0, N - (N - M)+1);
             
                //Поиск символа 0 в обрезанной строке
                
                string ch = "0";

               
                int indexOfstr_new = str_new.IndexOf(ch);
                // Перевод искомого числа в строквое значение
                string indexOfstr_new_string = indexOfstr_new.ToString();
                              
                string str_Yes_No = "";
                
                str_Yes_No = indexOfstr_new_string.Replace("-1", "No") + indexOfstr_new_string.Replace("0", "Yes") + indexOfstr_new_string.Replace("1", "Yes") + indexOfstr_new_string.Replace("2", "Yes") + indexOfstr_new_string.Replace("3", "Yes") + indexOfstr_new_string.Replace("4", "Yes") + indexOfstr_new_string.Replace("5", "Yes");


                str_Yes_No = str_Yes_No.Replace("-1", "No");
                str_Yes_No = str_Yes_No.Replace("0", "Yes");
                
                int ind1 = 0;
                ind1 = str_Yes_No.Length - 6;

                str_Yes_No = str_Yes_No.Substring(ind1) ;
                

                string s = "Yes";
                str_Yes_No = str_Yes_No.Remove(str_Yes_No.IndexOf(s) + s.Length);
                
                str_Yes_No = str_Yes_No.Replace("es", "Yes");
                str_Yes_No = str_Yes_No.Replace("YYes", "Yes");
                str_Yes_No = str_Yes_No.Replace("3Yes", "Yes");
                str_Yes_No = str_Yes_No.Replace("44Yes", "Yes");

                
                Console.WriteLine(str_Yes_No);
                

            }
        }
    }

}
