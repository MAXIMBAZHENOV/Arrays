using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class Extensions
    {
        public static void PrintElements<T>(this ArrayList<T> arrayList)
        {
            if(null == arrayList || arrayList.Length == 0)
            {
                Console.Write("[]");
                return;
            }

            Console.Write("[");
            for (int j = 0; j < arrayList.Length; j++)
            {
                if(j == 0)
                {
                    Console.Write($"{arrayList[j]}");
                }
                else
                {
                    Console.Write($",{arrayList[j]}");
                }
            }
            Console.Write("] - this is custom ArrayList");
            Console.WriteLine();
        }
    }
}
