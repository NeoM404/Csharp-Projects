using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{
    internal class Teacher: Student
    {
        public override void hasName()
        {
            //base.hasName();
            Console.WriteLine("The Teacher also has a name");
        }
    }
}
