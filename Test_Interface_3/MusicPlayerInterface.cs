using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    class MusicPlayerInterface : RadioPlayerInterface
    {
        bool switc;
        bool plays;
        bool next;
        bool prev;
        MusicFil[] listofMusic = new MusicFil[500];
        int totalMusic = 1;
        int i = 1;
        public void swit(bool on)
        {
            switc = on;
            if (switc)
            {
                Console.WriteLine("Switch on");
            }
            else
            {
                Console.WriteLine("Switch Of");
            }
        }

        public void retune(double frequency)
        {
            Console.WriteLine("Frequency :" + frequency + "Hz");
        }
        public void setVolume(int loudness)
        {
            Console.WriteLine("Loudness  :" + loudness);
        }

        public void changeChannel()
        {
            Console.WriteLine("Channel Change");
        }
        public void play(bool on)
        {
            plays = on;
            if (plays)
            {
                Console.WriteLine("\n------Play Music-----");
                Console.WriteLine("Music Title               : " + listofMusic[i].Title);
                Console.WriteLine("Music Artist              : " + listofMusic[i].Artist);
                Console.WriteLine("Music Year Of Release     : " + listofMusic[i].Release_Year);
                Console.WriteLine("Music Duration Of Seconds : " + listofMusic[i].Duration);
                Console.WriteLine("Music Serial Number       : " + i + "\n");
            }
            else
            {
                Console.WriteLine("Not Responding ");
            }

        }
        public void playNext(bool m_next)
        {
            next = m_next;
            if (next)
            {
                Console.WriteLine("\n-----Play next Music -----");
               // for (int i = 0+1; i < totalMusic; i++)
                i++;
                Console.WriteLine("Music Title               : " + listofMusic[i].Title);
                Console.WriteLine("Music Artist              : " + listofMusic[i].Artist);
                Console.WriteLine("Music Year Of Release     : " + listofMusic[i].Release_Year);
                Console.WriteLine("Music Duration Of Seconds : " + listofMusic[i].Duration);
                Console.WriteLine("Music Serial Number       : " + i +"\n");

            }
            else
            {
                Console.WriteLine("Not Responding");
            }
        }
        public void playPrevious(bool m_prev)
        {
            prev = m_prev;
            if (prev)
            {
                --i;
                Console.WriteLine("\n-----Play previous Music-----");
                Console.WriteLine("Music Title               : " + listofMusic[i].Title);
                Console.WriteLine("Music Artist              : " + listofMusic[i].Artist);
                Console.WriteLine("Music Year Of Release     : " + listofMusic[i].Release_Year);
                Console.WriteLine("Music Duration Of Seconds : " + listofMusic[i].Duration);
                Console.WriteLine("Music Serial Number       : " + i + "\n");

            }
            else
            {
                Console.WriteLine("Not Responding");
            }
        }
          
        public void AddNewMusic(MusicFil music)
        {
            if (totalMusic < 500)
            {
                listofMusic[totalMusic] = music;
                Console.WriteLine("\n--->Added New Music :" + listofMusic[totalMusic].Title);
                Console.WriteLine("--->Total Music : " + totalMusic);
                totalMusic++;
            }
            else
            {
                Console.WriteLine("--->Can Not Added New Music\n");
            }

        }
    }
}
