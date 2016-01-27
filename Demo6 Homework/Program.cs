using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            CD album = new CD { Name = "Endless Time of Numbers", Artist = "Number one In the World " };
            

            Song song1 = new Song { Songs = "Number 1 ", Length = 3.12 };
            Song song2 = new Song { Songs = "Number 2 ", Length = 3.44 };
            Song song3 = new Song { Songs = "Number 3 ", Length = 3.66 };
            Song song4 = new Song { Songs = "Number 4 ", Length = 3.44 };
            Song song5 = new Song { Songs = "Number 5 ", Length = 7.49 };
            Song song6 = new Song { Songs = "Number 6 ", Length = 6.36 };
            Song song7 = new Song { Songs = "Number 7 ", Length = 1.41 };
            Song song8 = new Song { Songs = "Number 8 ", Length = 9.34 };
            Song song9 = new Song { Songs = "Number 9 ", Length = 10.56 };
            Song song10 = new Song { Songs = "Number 10 ", Length = 12.02 };

            album.AddSong(song1);
            album.AddSong(song2);
            album.AddSong(song3);
            album.AddSong(song4);
            album.AddSong(song5);
            album.AddSong(song6);

            album.PrintCollection();
            
        }
    }
}
