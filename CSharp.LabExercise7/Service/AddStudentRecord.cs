using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.LabExercise7.Model;
using CSharp.LabExercise7.Helper;

namespace CSharp.LabExercise7.Service
{
    class AddStudentRecord
    {
        public static void AddStudent(HashSet<Student> Students)
        {
            try
            {
                Console.WriteLine("========== ADD STUDENT RECORD =========");
                Console.Write("Enter Student ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student First Name: ");
                string firstName = Console.ReadLine();
                if (!InputValidator.validNameInputs(firstName.ToUpper()))
                {
                    throw new Exception("Invalid First Name input");
                }
                Console.Write("Enter Student Last Name: ");
                string lastName = Console.ReadLine();
                if (!InputValidator.validNameInputs(lastName.ToUpper()))
                {
                    throw new Exception("Invalid Last Name input");
                }
                Console.Write("Enter Student Grade Level: ");
                string gradeLevel = Console.ReadLine();
                GradeLevelList gradeList = (GradeLevelList)Enum.Parse(typeof(GradeLevelList), gradeLevel, true);
                Console.Write("Enter Student Section: ");
                string section = Console.ReadLine();
                SectionList sect = (SectionList)Enum.Parse(typeof(SectionList), section, true);

                var student = new Student()
                {
                    ID = ID,
                    FirstName = firstName,
                    LastName = lastName,
                    GradeLevel = gradeList,
                    Section = sect,
                };

                if (Students.Add(student))
                {
                    Console.WriteLine("Student Record Added\n");
                }
                else
                {
                    Console.WriteLine("Student ID already exist\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
