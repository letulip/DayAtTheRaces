using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    class Greyhound
    {
        public string Name;
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random rnd = new Random();

        public Greyhound()
        {

        }

        public Greyhound(string name)
        {
            Name = name;
        }

        public bool Run()
        {

        }

        public void TakeStartingPosition()
        {

        }
    }
}
