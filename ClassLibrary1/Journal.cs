using System;

namespace ClassLibrary1;

public class Journal
{
	private int? mark;
	private readonly DateTime date;
        public DateTime? Date { get => date; }
	private readonly Employee teacher;
	public Employee teacher { get => teacher; }
	private readonly Student student;
	public Student student { get => student; }
	private readonly Discipline discipline;
	public Discipline discipline { get => discipline; }
	public Journal(int? mark, DateTime date, Employee teacher, Student student, Discipline discipline)
	{
		this.mark = mark;
		this.date = date ?? DateTime.Today;
		this.teacher = teacher;
		this.student = student;
		this.discipline = discipline;
	}
}
