namespace ClassLibrary1;

class Corpus
{
	public readonly string? title;
	public readonly string? address;
	private readonly Employee commandant;
	private readonly Organization organization;
	public Employee Commandant { get => commandant; }
	public Organization Organization { get => organization; }
	public Corpus(string? title, string? address, Employee commandant, Organization organization)
	{
		this.title = title;
		this.address = address;
		this.organization = organization;
		this.commandant = commandant;
	}
}
