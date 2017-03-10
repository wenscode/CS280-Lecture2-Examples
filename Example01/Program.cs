using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入名字");
            string name = Console.ReadLine();  //創造一個字串變數name，讓使用者輸入字，然後存成文字變數
            Console.Write("請輸入密碼");
            string password = Console.ReadLine();

            Console.WriteLine("Hi, {0}歡迎登入", name);  //{0}就用name這個變數去置換
        }
    }
}