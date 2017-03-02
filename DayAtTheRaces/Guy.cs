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

        public Guy(string name, int cash, Label myLabel, RadioButton myRadioButton)
        {
            Name = name;
            Cash = cash;
            MyBet = new Bet(0, 0, this);
            MyLabel = myLabel;
            MyRadioButton = myRadioButton;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.Description();
            MyRadioButton.Text = Name + " has $" + Cash;
        }

        public void ClearBet()
        {
            this.MyBet.Amount = 0;
            MyLabel.Text = MyBet.Description();
        }

        public bool PlaceBet(int BetAmount, int DogToWin, string dogName)
        {
            if (Cash >= BetAmount)
            {
                MyBet = new Bet(BetAmount, DogToWin, this);
                MyLabel.Text = MyBet.Description(dogName);
                return true;
            }
            else
            {
                this.MyLabel.Text = this.Name + " got not enough bucks to bet!";
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}
