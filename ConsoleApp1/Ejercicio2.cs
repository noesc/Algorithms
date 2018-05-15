using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ejercicio2
    {
        public bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            if (str1 == str2)
                return false;

            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();
            int n = 0;
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                char l = array1[i];
                n = 0;

                while (n < array1.Length)
                {
                    if (array1[n] == l)
                        count1++;

                    if (array2[n] == l)
                        count2++;

                    n++;
                }

                if (count1 != count2)
                    return false;
            }

            return true;
        }
    }
}
