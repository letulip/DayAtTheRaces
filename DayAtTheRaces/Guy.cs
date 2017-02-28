using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy()
        {

        }

        public Guy(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        public void UpdateLabels()
        {
            
        }

        public void ClearBet()
        {

        }

        //public bool PlaceBet(int BetAmount, int DogToWin)
        //{

        //}

        public void Collect(int Winner)
        {

        }
    }
}
