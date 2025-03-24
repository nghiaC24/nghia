using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public class MyStack
    {
        private Node top ; // Con trỏ chỉ đến phần đầu tiên trong ngăn xếp 
        // contructor
        public MyStack()
        {
            top = null; // Khởi tạo ngăn xếp rỗng 
        }
       // Thêm phần tử vào ngăn xếp (Push)
       public void Push (int value)
        {
            Node newNode = new Node(value); // Tạo một nút mới
            newNode.Next = top;// Liên kết node mới với phần tử nếu có
            top = newNode; // Cập nhật top
        }
        // Lấy phần tử ra khỏi ngăn xếp (Pop)
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Ngăn xếp rỗng, không thể pop.");
            }

            int value = top.Data;  // Lấy giá trị của phần tử trên đỉnh ngăn xếp
            top = top.Next;        // Di chuyển top đến phần tử tiếp theo
            return value;
        }
        // Lấy giá trị phần tử trên đỉnh mà không xóa (peek)
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Ngăn xếp rỗng, không thể peek.");
            }

            return top.Data;  // Trả về giá trị phần tử trên đỉnh
        }

        // Kiểm tra ngăn xếp có rỗng không
        public bool IsEmpty()
        {
            return top == null;  // Ngăn xếp rỗng nếu top là null
        }

        // Hiển thị nội dung ngăn xếp
        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Ngăn xếp rỗng.");
                return;
            }

            Node current = top;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
