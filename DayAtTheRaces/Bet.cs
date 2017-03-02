using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public Greyhound greyhound;

        public Bet()
        {

        }

        public Bet(int amount, int dog, Guy bettor)
        {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        }

        public string Description()
        {
            return Bettor.Name + " hasn't placed a bet";
        }

        public string Description(string dogName)
        {
            if (Amount > 0)
            {
                return Bettor.Name + " bets " + Amount + " on " + dogName;
            }
            else
                return Bettor.Name + " hasn't placed a bet";
        }

        public int PayOut(int Winner)
        {
            if(Winner == Dog)
            {
                return Amount * 2;
            }
            else
            {
                return -Amount;
            }
        }
    }
}