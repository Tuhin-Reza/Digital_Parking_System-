using System;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicPlayerInterface mi = new MusicPlayerInterface();            

            MusicFil mf1 = new MusicFil("AA","MM",2021,180);
            // mf1.show();
            // mf1.changeTitle("BB");
            //mf.show();
            MusicFil mf2 = new MusicFil("CC", "NN", 2021, 120);
            MusicFil mf3 = new MusicFil("DD", "OO", 2021, 90);
            MusicFil mf4 = new MusicFil("EE", "PP", 2021, 110);
            MusicFil mf5 = new MusicFil("FF", "WW", 2021, 80);
          
            mi.swit(true);
            mi.retune(50);
            mi.setVolume(10);
            mi.changeChannel();
            mi.AddNewMusic(mf1);
            mi.AddNewMusic(mf2);
            mi.AddNewMusic(mf3);
            mi.AddNewMusic(mf4);
            mi.AddNewMusic(mf5);
            mi.play(true);
            mi.playNext(true);
            mi.playPrevious(true);



            Console.ReadLine();
        }
    }
}
