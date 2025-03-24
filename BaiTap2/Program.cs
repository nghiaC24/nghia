using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập N và X từ bàn phím
            Console.WriteLine("Nhập số nguyên N (hệ 10): ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập cơ số X (2, 8, hoặc 16): ");
            int X = int.Parse(Console.ReadLine());

            // Chuyển số N sang cơ số X
            MyStack stack = new MyStack();
            string kq = ConvertToBase(N, X, stack);

            Console.WriteLine($"Số {N} trong hệ cơ số {X} là: {kq}");
        }

        // Hàm chuyển đổi số nguyên N sang cơ số X
        static string ConvertToBase(int N, int X, MyStack stack)
        {
            if (N == 0)
                return "0";
            // Dùng ngăn xếp để lưu lại các phần dư
            while (N > 0)
            {
                stack.Push(N % X);  // Lấy phần dư và đẩy vào ngăn xếp
                N = N / X;          // Chia N cho cơ số X
            }

            // Lấy các phần tử ra từ ngăn xếp để tạo chuỗi kết quả
            string kq  = "";
            while (!stack.IsEmpty())
            {
                int so = stack.Pop();
                kq += stack[so];  // Lấy ký tự tương ứng với phần dư
            }
            return kq;
        }
    }
}
