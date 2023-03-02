namespace ClassLibrary1 { 
/* https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit */
public class Group{
    private readonly string? name;
    public string? Name { get => name; }

    private readonly string? sokr;
    public string? Sokr { get => sokr; }

    private readonly string? chisl = "0";
    public string? Chisl { get => chisl; }

    private readonly int? year = 0;
    public int? Year { get => year; }

    private readonly Speciality speciality;
    public Speciality Speciality { get => speciality; }

    private readonly ClassTeacher classteacher;
    public ClassTeacher ClassTeacher { get => classteacher; }


    public Group(string? name, string? sokr, string? chisl, int? year, Speciality speciality, ClassTeacher classteacher)
    {
        this.name = name;
        this.sokr = sokr;
        this.chisl = chisl;
        this.year = year;
        this.speciality = speciality;
        this.classteacher = classteacher;
    }
}
}