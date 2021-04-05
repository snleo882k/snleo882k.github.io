using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOOP
{
    class Student
    {

        private string Name; // 1.truong

        // 2. Thuoc tinh
        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        //3. Phuong thuc (Method)
        public void StudentN(string stName)
        {
            Console.WriteLine("Tên tôi là:");
        }
        // 4. Phuong thuc(Method) Talk
        public void Talk(string stName)
        {
            Console.WriteLine("tôi là :");
        }


        
        static void Main(string[] args)
        {

        }
    }
}


