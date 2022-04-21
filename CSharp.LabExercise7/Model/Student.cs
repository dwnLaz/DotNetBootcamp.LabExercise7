using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise7.Model
{
    enum GradeLevelList
    {
        ONE = 1, TWO, THREE, FOUR, FIVE, SIX
    }
    enum SectionList
    {
        A = 1, B, C, D, E
    }
    class Student : IEquatable<Student>
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SectionList Section { get; set; }
        public GradeLevelList GradeLevel { get; set; }

        public bool Equals(Student other)
        {
            if (other == null)
            {
                throw new ArgumentException("Student object cannot be null");
            }

            return this.ID == other.ID;
        }

        public override string ToString()
        {
            return $"Student ID: {ID} | First Name: {FirstName} | Last Name: {LastName} | Grade Level: {GradeLevel} | Section: {Section}";
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
