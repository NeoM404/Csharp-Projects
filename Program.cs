using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

            Console.Write("Enter a number to cube: ");

            int cube = 0;
            bool isExcpection = false;

            do
            {
                try
                {
                    cube = Convert.ToInt32(Console.ReadLine());
                    isExcpection = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Arithmetic Exception thrown: {ex.Message}");
                    isExcpection = true;
                    Console.Write("Try again: ");

                }

            } while (isExcpection);

            Console.WriteLine($"Cube of {cube} is: {Cube(cube)}");



            string word = "Nen";

            Console.WriteLine($"{word} is a palindrome? {isWordPalindrome(word)}");
            
            Console.ReadKey();
        }

        static int Cube(int x)
        {
            return x*x*x;
        }

        static bool isWordPalindrome(string word)
        {
            int str_len = word.Length;

            word = word.Replace( " ", "").ToLower();

            for (int i = 0; i < str_len/2 ; i++) 
            {
                if (word[i] != word[(str_len - 1) - i])
                {
                    return false;
                }
                
            }

            return true;
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
