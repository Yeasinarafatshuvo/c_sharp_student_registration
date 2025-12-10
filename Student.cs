class Student{
    public string Name { get; private set; }
    public int ClassGrade { get; private set; }


    public Subject? AssignSubject {get; private set;}
    public Teacher? AssignedTeacher {get; private set;}

    public Student(string name, int classGrade)
    {
        Name = name;
        ClassGrade = classGrade;
    }

    public void Assign(Subject subject, Teacher Teacher)
    {
        AssignSubject = subject;
        AssignedTeacher = Teacher;
    }

}