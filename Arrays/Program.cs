using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void ArrayListTest()
        {
            ArrayList<int> customArrayList =
                new ArrayList<int>();

            customArrayList.Add(4);
            customArrayList.Add(5);
            customArrayList.Add(6);
            customArrayList.PrintElements();
            Console.WriteLine();
            try
            {
                customArrayList[5] = 20;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            customArrayList.Add(20);
            customArrayList.PrintElements();
            customArrayList.Insert(0,100);
            customArrayList.PrintElements();
        }
        static void ArrayTest()
        {
            int[] array = new int[] { 1, 2, 3 };

            array.PrintElements();
            array[1] = 10;
            array.PrintElements();

            try
            {
                array[3] = 10;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void LibraryListArray()
        {
            List<int> arrayList = new List<int> { 4, 5, 6 };
            arrayList.PrintElements();

            try
            {
                arrayList[4] = 20;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            arrayList.Add(20);
            arrayList.PrintElements();
            arrayList.Insert(0, 100);
            arrayList.PrintElements();
        }
        static void Main(string[] args)
        {
            LibraryListArray();
        }
    }
}
