using System;
using System.Collections.Generic;

namespace Ex5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student James = new Student("James");
            James.Gpa = 4.00;
            James.NumberOfCredits = 50;
            Student Yara = new Student("Yara");
            James.Gpa = 4.00;
            James.NumberOfCredits = 50;
            Course History = new Course("History");
            History.AddStudent(James);
            History.AddStudent(Yara);
            string grade = James.GetGradeLevel();
            string info = James.ToString();
            string classInfo = History.ToString();
            Console.WriteLine(grade);
            Console.WriteLine(info);
            Console.WriteLine(classInfo);
            Console.ReadLine();
        }
    }

    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            this.Gpa = ((this.Gpa * this.NumberOfCredits) + (grade * courseCredits)) / (this.NumberOfCredits + courseCredits);
            this.NumberOfCredits += courseCredits; 
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (this.NumberOfCredits < 30)
            { return "Freshman"; }
            else if (this.NumberOfCredits < 60)
            { return "Sophomore"; }
            else if (this.NumberOfCredits < 90)
            { return "Junior"; }
            else
            { return "Senior"; }

        }

        public override String ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            Student studentObj = obj as Student;
            return StudentId == studentObj.StudentId;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return StudentId;
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public List<Student> Students = new List<Student>();

        public Course(string name, int credits)
        {
            Name = name;
            Credits = credits;
            Students = new List<Student>();
        }

        public Course(string name)
            : this(name, 0) { }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public override String ToString()
        {
            int num = this.Students.Count;
            string roster = "";
            foreach (Student pupil in this.Students)
            {
                roster += pupil.Name + "\n";
            }
            string result = Name + " (Credits: " + Credits + ", Students: " + num + ")\n" + "Roster:\n" + roster;
            return result;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            Course courseObj = obj as Course;
            return Name == courseObj.Name;
        }
    }

}

