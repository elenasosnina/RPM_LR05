namespace ClassLibrary1;

public class Pair
{
    private DateTime start;
    private DateTime end;
    private DateTime breakStart;
    private DateTime breakEnd;
    private Shift shift;
    public Pair(DateTime start, DateTime end, DateTime breakStart, DateTime breakEnd)
    {
        this.start = start;
        this.end = end;
        this.breakStart = breakStart;
        this.breakEnd = breakEnd;
        shift = new Shift();
}