using System.Collections.Generic;
class SchoolService
{
    private readonly List<Student> _students = new List<Student>();


    public void RegisterStudent(string name, int classGrade)
    {
        Student s = new Student(name, classGrade);
        AssignSubjectAndTeacher(s);
        _students.Add(s);
    }

    public void AssignSubjectAndTeacher(Student student)
    {

        if (student.ClassGrade <= 5)
        {
            student.Assign(new Subject("Math"), new Teacher("Mr. Rahim"));
        }
        else if (student.ClassGrade <= 8)
        {
            student.Assign(new Subject("Science"), new Teacher("Mrs. Ruba"));
        }
        else
        {
            student.Assign(new Subject("Physics"), new Teacher("Dr. Hasan"));
        }

        
    }

    public void ShowAllStudents()
    {
        foreach(var student in _students)
        {
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Class: {student.ClassGrade}");
            Console.WriteLine($"Subject: {student.AssignSubject?.Name}");
            Console.WriteLine($"Teacher: {student.AssignedTeacher?.Name}");
            Console.WriteLine();
        }
    }

}