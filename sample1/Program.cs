using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            Console.Write("This is my sample project " );
            for(i=1; i<=20; i++)
            {
                i =  i * 2;
                Console.Write(i + " ");
                Console.Read();
                
            }
        }
    }
}
