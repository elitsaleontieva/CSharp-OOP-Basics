using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
            var n = int.Parse(Console.ReadLine());

            var listOfSongs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var chars = ";".ToCharArray();
            
                var parts = input.Split(chars, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (parts.Length == 3)
            {
                try { 
                var artistName = parts[0];
                        var songName = parts[1];
                        var length = parts[2];
                        var lengthParts = parts[2].Split(':').ToArray();
                        var minutes = int.Parse(lengthParts[0]);
                        var seconds = int.Parse(lengthParts[1]);

                        Song song = new Song(artistName, songName, minutes, seconds, length);

                    Console.WriteLine("Song added.");
                    listOfSongs.Add(song);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }

        var totalSeconds = listOfSongs.Select(x => x.Seconds).Sum() + listOfSongs.Select(x => x.Minutes).Sum() * 60;
        TimeSpan t = TimeSpan.FromSeconds(totalSeconds);
        
        

        Console.WriteLine($"Songs added: {listOfSongs.Count}");


        Console.WriteLine($"Playlist length: {t.Hours}h {t.Minutes}m {t.Seconds}s");
        

        


    }
}

