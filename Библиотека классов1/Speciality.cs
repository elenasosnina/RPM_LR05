// Задание - " https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit "
namespace ClassLibrary1
{
    public class Speciality
    {
        private readonly string? name; // имя
        public string? Name { get => name; }

        private readonly string? reduction; // Соращение

        public string? Reduction { get => reduction; }

        public static DateTime Now { get; } // Дата
        private DateTime? date;
        public DateTime? Date { get => date; }
        Speciality(string? name, string? reduction, DateTime? date)
        {
            this.name = name;
            this.reduction = reduction;
            this.date = date ?? DateTime.Today;
        }
    }

}
