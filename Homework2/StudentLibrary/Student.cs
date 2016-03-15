using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        public string name;
        public bool isHappy;
        public string email;
        public string address;
        public string website;

        public void DoSomething()
        {
            Console.WriteLine("沒有要幹嘛!!");
            Console.WriteLine("我心情好嗎? {0}", this.isHappy);
        }
    }
}