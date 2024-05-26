using System.Dynamic;

namespace getters_and_setters;

public class Movie
{
    public string title;
    public string director;
    private string rating {get; set;}


    public Movie(string aTitle, string aDirector, string aRating)
    {
        title = aTitle;
        director = aDirector;
        Rating = aRating;
    }

    public string Rating 
    {
        get {return rating;}
        set 
        {
            if (value == "G" || value == "PG" || value == "PG-13" || value == "NR") 
            {
                rating = value;
            }
            else 
            {
                rating = "NR";
            }

        }
    }
}
