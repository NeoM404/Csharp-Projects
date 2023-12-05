using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = 5;

            for (int i = 0; i < l; i++) {
            
                for (int j = 0; j < l; j++)
                {

                    if ((j == l-1-i) )//&& (i != l - 1))
                    { 
                        Console.Write("/");
                    }
                    else if (i == l-1)
                    {
                        Console.Write("_");   
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("|");
            }
        }
    }
}
