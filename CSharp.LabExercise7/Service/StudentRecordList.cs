using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.LabExercise7.Model;

namespace CSharp.LabExercise7.Service
{
    class StudentRecordList
    {
        public static void ListStudent(HashSet<Student> Students)
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("The Student Record is Empty\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\t\t========== STUDENT RECORD LIST =========");
                IEnumerable<Student> query = Students.OrderBy(stud => stud.ID);
                foreach (var student in query)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine();
            }
        }
    }
}
