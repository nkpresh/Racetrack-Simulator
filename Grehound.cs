using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator
{
   public class Grehound
    {
        public int StartingPosition;
        public int RacetrackLenght;
        public PictureBox MyPictureBox=null;
        public int Location=0;
        public Random Randomizer;

        public bool Run()
        {

            Location+=Randomizer.Next(1, 4); 
            
            MyPictureBox.Left = StartingPosition + Location;
            for (int i = 0; i < 4; i++)
            {
                int winer = i + 1;
            }
                if (Location == RacetrackLenght - 185)
                { return true; }
                else
                { return false; }
        }
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = Location;
            StartingPosition= 0;
        }
    }
}
