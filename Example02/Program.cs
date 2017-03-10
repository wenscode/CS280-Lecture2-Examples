using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(0.1f + 0.2f == 0.3f);   // 會顯示出這個等式是true 還是false，要記得浮點數不能拿來比較。
            float floatPI = 3.141592653589793238f; //只會精準到小數點後第七位，小數點後記得加f
            double doublePI = 3.141592653589793238; //只會精準到小數點後，15-16位
            Console.WriteLine("Float PI is: {0}", floatPI);
            Console.WriteLine("Double PI is: {0}", doublePI);

            Console.WriteLine(1 / 2 * 10); //執行結果=0 (小數點後無條件捨去)
            Console.WriteLine(1.0 / 2.0); //執行結果=0.5
            Console.WriteLine(1.0 / 2.0 * 10.0); //執行結果=5
        }
    }
}