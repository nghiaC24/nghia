using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
     public class Node
    {
        public int Data;// Giá trị phần tử trong ngăn xếp 
        public Node Next; // con trỏ tới phần tử tiếp trong ngăn xếp 
        //contructor
        public Node (int y)
        {
            Data = y ; // Gán giá trị cho node
            Next = null; // Ban đầu chưa liên kết node khác
        }
    }
}
