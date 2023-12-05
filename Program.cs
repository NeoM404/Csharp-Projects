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

            Student student1 = new Student();
            Student student2 = new Student(222,"Neo","Exceptional Student");
            Teacher teacher = new Teacher();
            
            

            Console.WriteLine($"Is student1 a valid student? {student1.isStudentValid()}; How about student2? {student2.isStudentValid()}");

            student1.hasName();

            teacher.hasName();


            
            Console.ReadKey();
        }

        static void printTriangle()
        {
            int l = 5;

            for (int i = 0; i < l; i++)
            {

                for (int j = 0; j < l; j++)
                {

                    if ((j == l - 1 - i))//&& (i != l - 1))
                    {
                        Console.Write("/");
                    }
                    else if (i == l - 1)
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
