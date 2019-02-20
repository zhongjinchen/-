using System;

namespace 取最大值
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] array = new int[] { 6, 3, 7, 2, 5, 9 };
            Console.WriteLine("数组：6，3，7，2，5，9");

            int max = array[0];
            Console.WriteLine($"最大值的初始值为:{max}");
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    Console.WriteLine($"第{i}次比较，{array[i]}>{max},目前最大值为{array[i]}");max = array[i];

                }
                else
                {
                    Console.WriteLine($"第{i}次比较，{array[i]}<={max},最大值不变"+max);
                }
            }
            Console.WriteLine($"最后的结果，最大数字是：" + max);
            Console.Read();


        }
    }
}
