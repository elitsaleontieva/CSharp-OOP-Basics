using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;
    private string length;        
    
    public string ArtistName
    {
        get
        {
            return this.artistName;
        }
        set
        {
            if (value.Length<3 || value.Length>20)
            {
                throw new InvalidArtistNameException();
            }
            else if (value == null)
            {
                throw new InvalidSongException();
            }
            else
            {
                this.artistName = value;
            }
        }
    }
    public string SongName
    {
        get
        {
            return this.songName;
        }
        set
        {
            if (value.Length<3 || value.Length>30)
            {
                throw new InvalidSongNameException();
            }
            else if (value == null)
            {
                throw new InvalidSongException();
            }
            else
            {
                this.songName = value;
            }
        }
    }
    public int Minutes
    {
        get
        {
            return this.minutes;
        }
        set
        {
            if (value<0 || value>14)
            {
                throw new InvalidSongMinutesException();
            }
            else
            {
                this.minutes = value;
            }
        }
    }
    public int Seconds
    {
        get
        {
            return this.seconds;
        }
        set
        {
            if (value<0 || value>59)
            {
                throw new InvalidSongSecondsException();
            }
            else
            {
                this.seconds = value;
            }
        }
    }

    public string Length
    {

        get
        {
            return this.length;
        }
        set
        {
            var minutesAndSeconds = value.Split(':').ToArray();
            if (int.Parse(minutesAndSeconds[0])<0 || int.Parse(minutesAndSeconds[0])>14  
                || int.Parse(minutesAndSeconds[1])>59 || int.Parse(minutesAndSeconds[1])<0)
            {
                throw new InvalidSongLengthException();
            }
            else if (value == null)
            {
                throw new InvalidSongException();
            }
            else
            {
                this.length = value;
            }
        }
    }



    public Song(string artistName, string songName, int minutes, int seconds, string length)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
        this.Length = length;
    }

}

