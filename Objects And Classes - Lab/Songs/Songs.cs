using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Songs
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberSongs; i++)
            {
                string[] song = Console.ReadLine().Split("_");
                Song newSong = new Song();
                newSong.TypeList = song[0];
                newSong.Name = song[1];
                newSong.Time = song[2];
                songs.Add(newSong);
            }

            string filter = Console.ReadLine();
            Console.WriteLine(filter == "all" ? string.Join(Environment.NewLine, songs.Select(s => s.Name)) : string.Join(Environment.NewLine, songs.Where(s => s.TypeList == filter).Select(s => s.Name)));
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
