using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class StudentTS
    {
        private static int counter = 0;
        private static StudentTS enrollment = null;
        private static readonly object stdlock = new object();
        private StudentTS()
        {
            List<string> studentNames = new List<string> { "Mahek", "Vidhi", "Janvi" };
            foreach (string studentName in studentNames)
            {
                Console.WriteLine(studentName);
                counter++;
            }
            Console.WriteLine("Total Students : " + counter.ToString());
        }

        public static StudentTS Instance
        {
            get
            {
                lock (stdlock)
                {
                    if (enrollment == null)
                    {
                        if(enrollment==null)
                        enrollment = new StudentTS();
                    }
                    return enrollment;
                }
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintStudents()
        {
            StudentTS printStudent = StudentTS.Instance;
            printStudent.PrintDetails("Here is the details of the sudents");
        }
        static void Main(string[] args)
        {
            PrintStudents();
        }
    }
}
