using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Program
    {
        
       // public int AddNumbers(int fn, int sn)
        public static void Main()
        {
            int fn, sn; 
            Console.Write("ENTER FIRST NUMBER ");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENTER SECOND NUMBER ");
            sn = Convert.ToInt32(Console.ReadLine());
            int sum = fn + sn;
            Console.WriteLine("SUM = " + sum);
           // Console.ReadLine();
            Console.ReadKey();
            
        }
    }
    
    
}
