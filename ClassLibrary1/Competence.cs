//https://docs.google.com/document/d/1P3kBxfRo420TN9bADSITAmdnIWRJUrNsCpj2ENN1YQs/edit
namespace ClassLibrary1;

public class Competence
{
	private int? code;
	private string? content;
	private readonly Speciality speciality;
	public Speciality speciality { get => speciality; }
	public Competence(int? code , string? content , Speciality speciality)
	{
		this.code = code;
		this.content = content;
		this.speciality = speciality;
	}
}
