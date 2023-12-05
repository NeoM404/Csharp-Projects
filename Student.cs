using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP2
{
    internal class Student
    {
        public int id { get; set; }

        private string _name = string.Empty;
        public string name { 
            get { return _name; } 
            set { _name = value; } 
        }
        public string description { get; set; }

      public Student(int oID, string oName, string oDescription) 
      {
            this.id = oID;
            this.name = oName;
            this.description = oDescription;
      }

        public Student() { }
        
      public bool isStudentValid() 
      {
            if (this.name == string.Empty) 
            {   
                return false;
            }
            else
                return true;
      }

        public virtual void hasName()
        {
            Console.WriteLine("Student has a name");
        }
    }
}
