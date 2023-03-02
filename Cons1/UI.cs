using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class UI
{
    public static void Print(Student student)
    {
        Console.WriteLine(student.Name);
        Console.WriteLine(student.S_name);
        Console.WriteLine(student.P_name);
        Console.WriteLine(student.Date);
        Print(student.Group);
    }

    public static void Print(Auditory auditory)
    {
        Console.WriteLine(auditory.Name);
        Console.WriteLine(auditory.Mest);
        Console.WriteLine(auditory.Window);
        Print(auditory.Employee);
        Print(auditory.Equipment);
    }

    public static void Print(Group group)
    {
        Console.WriteLine(group.Name);
        Console.WriteLine(group.Sokr);
        Console.WriteLine(group.Chisl);
        Console.WriteLine(group.Year);
        Print(group.ClassTeacher);
        Print(group.Speciality);
    }

    public static void Print(Employee employee)
    {
        Console.WriteLine(employee);
    }

    public static void Print(Equipment equipment)
    {
        Console.WriteLine(equipment);
    }

    public static void Print(Speciality speciality)
    {
        Console.WriteLine(speciality);
    }
    public static void Print(ClassTeacher classTeacher)
    {
        Console.WriteLine(classTeacher);
    }
}

