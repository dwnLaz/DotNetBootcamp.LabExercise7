using System;
using System.Collections.Generic;
using CSharp.LabExercise7.Model;

namespace CSharp.LabExercise7.Service
{
    class DeleteStudentRecord
    {
        public static void DeleteStudent(HashSet<Student> Students)
        {
            Console.Clear();
            try
            {
                StudentRecordList.ListStudent(Students);
                if (Students.Count == 0)
                {
                    return;
                }
                Console.Write("\nEnter Student ID To Delete: ");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (Student student in Students)
                {
                    if (student.ID == id)
                    {
                        if (Students.Remove(student))
                        {
                            Console.WriteLine("\nStudent Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("\nStudent Not Found");
                        }
                        return;
                    }
                }
                throw new Exception("\nStudent's id does not exist");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
