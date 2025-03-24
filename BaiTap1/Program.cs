using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Stack stack = new Stack(32);
            Console.WriteLine("Cho biết số nguyên N (Hệ 10); ");
            int n = int.Parse(Console.ReadLine());
            int so = n;
            while (n>0)
            {
                stack.Push(n % 2);
                n = n / 2;
            }
            string kq = "";
            while (!stack.IsEmpty())
            {
                kq+= stack.Pop();
            }
            Console.WriteLine($"Số Nguyên {so} (hệ 10) là: {kq} (hệ 2)");
            Console.ReadLine();
        }
    }
}
