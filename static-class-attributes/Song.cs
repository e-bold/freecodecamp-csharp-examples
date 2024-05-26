namespace static_class_attributes;

public class Song
{
    public string title;
    public string artist;
    public int duration;
    public static int songCount = 0;

    public Song(string aTitle, string aArtist, int aDuration)
    {
        Console.WriteLine("Creating a new song");
        title =aTitle;
        artist = aArtist;
        duration = aDuration;
        songCount++;
    }

    public int getSongCount()
    {
        return songCount;
    }
}
