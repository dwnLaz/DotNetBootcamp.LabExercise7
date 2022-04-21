using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.LabExercise7.Model;
using System.IO;

namespace CSharp.LabExercise7.Service
{
    class SaveToFile
    {
        public static void Exit(HashSet<Student> Students)
        {
            if(Students.Count != 0)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\studentdb." + DateTime.Now.ToString("MMddyyyyhhmmss") + ".txt";
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    foreach (Student student in Students)
                    {
                        sw.WriteLine(student.ToString());
                    }
                }
            }
            Environment.Exit(0);
        }
    }
}
