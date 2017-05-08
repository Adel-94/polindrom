using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,j,copy;
            Console.Write("Birinci intervali daxil edin :  ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci intervali daxil edin :  ");
            b = Convert.ToInt32(Console.ReadLine());
            for (  int i=a; i <= b; i++)
            {
                int netice = 0;
                copy = i;
                j = i;
                while (j> 0)
                {
                   netice = netice * 10 + j % 10;

                    j = j / 10;
                }

                if (netice == copy)
                {
                 Console.WriteLine(copy);

                } 
            }
            
            Console.ReadLine();
        }
        
    }
}
