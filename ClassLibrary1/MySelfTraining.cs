namespace ClassLibrary1;

public class MySelfTraining
{
    private readonly Name name;
    public Name name { get => name; }// название

    private readonly Equipment equipment; 
    public Equipment Equipment { get => equipment; } //ссылка на сотрудника

    private readonly List<Student> student; // список ссылок на студентов
    public List<Student> student { get => student; }
    public MySelfTraining(Name name, Student student, Equipment equipment) // конструктор
    {
        this.name = name;
        this.student = student;
        this.equipment = equipment;
    }
}


