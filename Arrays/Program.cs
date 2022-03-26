using System;

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
        static void Main(string[] args)
        {
            ArrayListTest();
        }
    }
}
