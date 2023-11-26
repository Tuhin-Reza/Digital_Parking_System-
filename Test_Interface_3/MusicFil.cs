using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    class MusicFil
    {
        String title;
        String artist;
        int yearOfRelease;
        int durationInSeconds;
        int  music_counter=0;
        
        public MusicFil() { }
        public MusicFil(string title,string artist,int yearOfRelease,int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
            music_counter++;
        }
        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public string Artist
        {
            set { artist = value; }
            get { return artist; }
        }
        public int Release_Year
        {
            set { yearOfRelease = value; }
            get { return yearOfRelease ; }
        }
        public int Duration
        {
            set { durationInSeconds = value; }
            get { return durationInSeconds; }
        }
        public  void changeTitle(string title)
        {
            this.title = title;
        }

        public void show()
        {
            Console.WriteLine("Music Title               : "+title);
            Console.WriteLine("Music Artist              : " + artist);
            Console.WriteLine("Music Year Of Release     : " + yearOfRelease);
            Console.WriteLine("Music Duration Of Seconds : " + durationInSeconds+"\n");

        }

    }
}
