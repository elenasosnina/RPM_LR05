using System;

namespace ClassLibrary;

public class Journal
{
	private int? mark;
	private int? date;
	private readonly Employee teacher;
	public Employee teacher { get => teacher; }
	private readonly Student student;
	public Student student { get => student; }
	private readonly Discipline discipline;
	public Discipline discipline { get => discipline; }
	public Journal(int? mark, int? date, Employee teacher, Student student, Discipline discipline)
	{
		this.mark = mark;
		this.date = date;
		this.teacher = teacher;
		this.student = student;
		this.discipline = discipline;
	}
}
