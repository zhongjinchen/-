using System;

namespace 取最大值
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] array = new int[] { 6, 3, 7, 2, 5, 9 };

           int max = array[0];
            for (int i = 1; i < array.Length; i++)

            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(@"飞哥最""帅""");
            Console.Read();


        }
    }
}
