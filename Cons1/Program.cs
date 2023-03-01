using ClassLibrary1;

while (true)
{
    try
    {
        Console.WriteLine("Какой класс Вы хотите создать?");
        switch (Console.ReadLine())
        {
            case "Lesson": 
                PrintLesson(CreateClassLesson());
                break;
            case "Student":
                UI.Print(ClassCreator.Student());
                break;
            case "Auditory":
                UI.Print(ClassCreator.Auditory());
                break;
            default:
                Console.WriteLine("Такого класса не существует");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Lesson CreateClassLesson()
    {
        return new Lesson(
            DateTime.Now,
            CreateClassPair(),
            CreateClassEquipment(),
            CreateClassTypeLesson(),
            CreateClassDiscipline(),
            CreateClassAuditory());
    }


Auditory CreateClassAuditory()
{
    throw new NotImplementedException();
}

Discipline CreateClassDiscipline()
{
    throw new NotImplementedException();
}

TypeLesson CreateClassTypeLesson()
{
    throw new NotImplementedException();
}

Equipment CreateClassEquipment()
{
    throw new NotImplementedException();
}

Equipment CreateClassEmployee()
{
    throw new NotImplementedException();
}

Pair CreateClassPair()
{
    throw new NotImplementedException(); //trycatch отлов исключений

}
Group CreateClassGroup()
{
    throw new NotImplementedException(); //trycatch отлов исключений

}


void PrintLesson(Lesson lesson)
{
    Console.WriteLine(lesson.Data);
    PrintPair(lesson.Pair);
    PrintEquipmentr(lesson.Equipment);
    PrintTypeLesson(lesson.TypeLesson);
    UI.Print(ClassCreator.Auditory());
    PrintDiscipline(lesson.Discipline);
}

void PrintDiscipline(Discipline discipline)
{
    throw new NotImplementedException();
}

void PrintTypeLesson(TypeLesson typeLesson)
{
    throw new NotImplementedException();
}

void PrintEmployee(Employee employee)
{
    throw new NotImplementedException();
}

void PrintEquipmentr(Equipment equipment)
{
    throw new NotImplementedException();
}

void PrintPair(Pair pair)
{
    throw new NotImplementedException();
}
void PrintGroup(Group group)
{
    throw new NotImplementedException();
}
