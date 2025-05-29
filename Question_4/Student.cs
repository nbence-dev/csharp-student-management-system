using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    // Represents a student with a name and ID
    class Student
    {
        

        public string Name { get; set; }
        public string ID { get; set; }

        public Student(string name, string iD)
        {
            Name = name;
            ID = iD;
        }
    }
}
