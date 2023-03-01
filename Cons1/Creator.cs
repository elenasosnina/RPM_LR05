using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassCreator
{
    public static Auditory Auditory()
    {
        Console.Write("Введите название: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите кол-во посадочных мест: ");
        int mest = Convert.ToInt16(Console.ReadLine() ?? "");
        Console.Write("Введите кол-во окон: ");
        int window = Convert.ToInt16(Console.ReadLine() ?? "");
        return new Auditory(name, Employee(), mest, window, Equipment());
    }

    public static Student Student()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите фамилию: ");
        string s_name = Console.ReadLine() ?? "";
        Console.Write("Введите отчество: ");
        string p_name = Console.ReadLine() ?? "";
        Console.Write("Введите дату рождения: ");
        DateTime date = CreateDateTime();

        return new Student(name, s_name, p_name, Group(), date);
    }

    static DateTime CreateDateTime()
    {
        Console.Write("Введите год: ");
        _ = int.TryParse(Console.ReadLine(), out int year);
        Console.Write("Введите месяц: ");
        _ = int.TryParse(Console.ReadLine(), out int month);
        Console.Write("Введите день: ");
        _ = int.TryParse(Console.ReadLine(), out int day);

        return new DateTime(year, month, day);
    }

    public static Group Group()
    {
        return null;
    }
    public static Employee Employee()
    {
        return null;
    }

    public static Equipment Equipment()
    {
        return null;
    }
}