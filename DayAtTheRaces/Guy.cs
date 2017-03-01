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

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (Cash >= BetAmount)
            {
                Bet bet = new Bet(BetAmount, DogToWin, this);
                return true;
            }
            else
            {
                MessageBox.Show(this.Name + " got not enough buks to bet!");
                return false;
            }
        }

        public void Collect(int Winner)
        {

        }
    }
}
