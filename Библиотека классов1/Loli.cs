using ClassLibrary1;

while (true)
{
    Console.WriteLine("Введите имя класса");
    switch (Console.ReadLine())
    {
        case "Employee":
            Console.WriteLine(CreateLoli().SName);
            Console.WriteLine(CreateLoli().Name);
            Console.WriteLine(CreateLoli().PName);
            break;
        default: 
            Console.WriteLine("Такого класса не существует");
            break;
    }
}

static Employee CreateEmployee()
{
    Console.Write("Введите фамилию: ");
    string? s_Name = Console.ReadLine();
    Console.Write("Введите имя: "); 
    string? Name = Console.ReadLine();
    Console.Write("Введите отчество: "); 
    string? p_Name = Console.ReadLine();
    return new Employee((s_Name, Name, p_Name));
}

//Класс
namespace ClassLibrary1
{
    public class Employee
    {
        private readonly string s_name;
        public string SName { get => s_name; }

        private readonly string name;
        public string Name { get => name; }

        private readonly string p_name;
        public string PName { get => p_name; }
        public Employee(string s_name, string name, string p_name)
        {
            this.s_name = s_name;
            this.name = name;
            this.p_name = p_name;
        }

        public Employee((string? s_Name, string? Name, string? p_Name) value)
        {
        }
    }
}
