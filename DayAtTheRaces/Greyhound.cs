using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public string Name;
        public int StartingPosition = 5;
        public int RacetrackLength = 708;
        public PictureBox MyPictureBox;
        public int Location = 1;
        //public Random rnd = new Random();

        public Greyhound()
        {

        }

        public Greyhound(string name, PictureBox myPictureBox)
        {
            Name = name;
            MyPictureBox = myPictureBox;
        }

        public bool Run(int location)
        {
            Location = location;
            MyPictureBox.Left += StartingPosition + Location;

            if (MyPictureBox.Left >= MyPictureBox.Parent.Width - MyPictureBox.Width)
            {
                
                return true;
            }
            else
                return false;
            
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
