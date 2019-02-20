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

            string firstname = "Jin";
            string secondname = "LuWei";

            //拼接
            Console.WriteLine(firstname+secondname);
            //嵌入
            Console.WriteLine("姓名为：{0}{1}",firstname,secondname);
            Console.WriteLine($"姓名为：{firstname}{secondname}");
            //截取
            Console.WriteLine("JinLuWei".Substring(3,5));
            //替换
            Console.WriteLine("luwei8岁".Replace("8","18"));

            Console.Read();
        }
    }
}
