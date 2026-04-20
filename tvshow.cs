public class TVShow
{
    public string Title { get; set; }
    public int Seasons { get; set; }

    public TVShow(string title, int seasons)
    {
        Title = title;
        Seasons = seasons;
    }

    public override string ToString()
    {
        return $"{Title} - {Seasons} seasons";
    }
}