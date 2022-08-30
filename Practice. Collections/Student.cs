using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe_IT_Academy.Practice._Collections
{
    public class Student
    {
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static HashSet<Student> GetCommonStudents(List<Student> studentsFirst, List<Student> studentSecond)
        {
            HashSet<Student> studentsOne = new HashSet<Student>(studentsFirst);
            HashSet<Student> studentSTwo = new HashSet<Student>(studentSecond);
            studentsOne.IntersectWith(studentSTwo);

            return studentsOne ?? null;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
