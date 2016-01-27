using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_Homework
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }

        private List<Song> songs;

        public CD()
            {
            songs = new List<Song>();
            }

            public void AddSong(Song song)
           {

            songs.Add(song);
           
           }

      
        public void PrintCollection()
        {
            Console.WriteLine(Artist + " " + Name + " ");
            Console.WriteLine("Songs in the album");
            foreach (Song song in songs )
            {
                Console.WriteLine(song.ToString());
            }
        }
        
        

    }
}
