using System;

public class Program
{
    public static void Main(string[] args)
    {
        SchoolService schoolService = new SchoolService();

        schoolService.RegisterStudent("John", 5);
        schoolService.RegisterStudent("Jane", 6);
        schoolService.RegisterStudent("Jack", 7);
        schoolService.RegisterStudent("Jill", 8);
        schoolService.RegisterStudent("Joe", 9);

        schoolService.ShowAllStudents();
        Console.ReadLine();

    }
}