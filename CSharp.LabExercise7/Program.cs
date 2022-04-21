using System;
using System.Collections.Generic;
using CSharp.LabExercise7.Service;
using CSharp.LabExercise7.Model;
using CSharp.LabExercise7.Helper;

namespace CSharp.LabExercise7
{   
    class StudentRecordManager
    {
        HashSet<Student> Students;
        public StudentRecordManager()
        {
            this.Students = new HashSet<Student>()
            {
                new Student() { ID = 4, FirstName = "John", LastName = "Doe", GradeLevel = GradeLevelList.TWO, Section = SectionList.B },
                new Student() { ID = 5, FirstName = "Ward", LastName = "Doe", GradeLevel = GradeLevelList.ONE, Section = SectionList.C },
                new Student() { ID = 6, FirstName = "Cris", LastName = "Doe", GradeLevel = GradeLevelList.THREE, Section = SectionList.A },
            };
            Logger logger = Logger.GetInstance();
            logger.AddToLog();
        }

        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] - Add     Records");
                Console.WriteLine("[2] - List    Records");
                Console.WriteLine("[3] - Modify  Records");
                Console.WriteLine("[4] - Delete  Records");
                Console.WriteLine("[5] - Exit    Program");
                try
                {
                    Console.Write("\nSelect your choice: ");
                    string choice = Console.ReadLine();
                    if (InputValidator.validIntInputs(choice))
                    {
                        throw new Exception("Please enter a number from 1-5.");
                    }
                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            AddStudentRecord.AddStudent(Students);
                            break;
                        case "2":
                            Console.Clear();
                            StudentRecordList.ListStudent(Students);
                            break;
                        case "3":
                            Console.Clear();
                            UpdateStudentRecord.ModifyStudent(Students);
                            break;
                        case "4":
                            Console.Clear();
                            DeleteStudentRecord.DeleteStudent(Students);
                            break;
                        case "5":
                            SaveToFile.Exit(Students);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("\nPress Any Key To Continue...");
                Console.ReadLine();
            }
        }        
    }    
    
    class Program
    {
        static void Main(string[] args)
        {
            StudentRecordManager studentRecordManager = new StudentRecordManager();
            studentRecordManager.Start();
        }
    }
}