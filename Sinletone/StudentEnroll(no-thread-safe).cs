using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public  class Student
    {
        private static int counter = 0;
        private static Student Enrollment = null;
        public static Student GetEnrollStudents
        {
            get
            {
                if (Enrollment == null)
                    Enrollment = new Student();
                return Enrollment;
            }
        }

        private Student()
        {
            List<string> studentNames = new List<string> {"Mahek" ,"Vidhi", "Janvi"};
            foreach(string studentName in studentNames)
            {
                Console.WriteLine(studentName);
                counter++;
            }
            Console.WriteLine("Total Students : " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}


