namespace ImplementingDependencyInjection;

public class ShortDate
{
    private readonly string _date;

    public ShortDate()
    {
        _date = DateTime.Now.ToShortDateString();
    }

    public string GetDate()
    {
        return _date;
    }
}