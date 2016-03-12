using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Student1
    {
        public int studentID { get; set; }

        public string Content(string name, string address, string tel, string email)
        {
            return "姓名: " + name + " 地址: " + address + " 電話: " + tel + " 電郵: " + email;
        }

        public Student1()
        {
            studentID = 0;
        }
    }
}