namespace Domain.Common;

public class SerieBase
{
    public string Title { get; set; }
    public int Seasons { get; set; }
    public List<string> Genre { get; set; }
    public string Description { get; set; }
    public int ReleaseYear { get; set; }
}
