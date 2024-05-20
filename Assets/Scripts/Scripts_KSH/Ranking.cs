public class Ranking
{
    public string name { get; set; }
    public int score { get; set; }

    public Ranking(string _name, int _score)
    {
        name = _name;
        score = _score;
    }
}