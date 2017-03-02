using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            lblMinimumBet.Text = "Minimum bet: $ " + numudBet.Value.ToString();
            //rbtnJoe.Text = joe.Name + " has $" + joe.Cash;
            //rbtnBob.Text = bob.Name + " has $" + bob.Cash;
            //rbtnAl.Text = al.Name + " has $" + al.Cash;

            Guy joe = new Guy("Joe", 50, lblJoesBet, rbtnJoe);
            Guy bob = new Guy("Bob", 75, lblBobsBet, rbtnBob);
            Guy al = new Guy("Al", 45, lblAlsBet, rbtnAl);

            Greyhound light = new Greyhound("Lightning", pbxLightning);
            Greyhound quinn = new Greyhound("McQuinn", pbxMcQuinn);
            Greyhound slayer = new Greyhound("Rabbit Slayer", pbxRabbitSlayer);
            Greyhound helper = new Greyhound("Santa's Little Helper", pbxSantasLittleHelper);

            greyhounds[0] = light;
            greyhounds[1] = quinn;
            greyhounds[2] = slayer;
            greyhounds[3] = helper;
            
            guys[0] = joe;
            guys[1] = bob;
            guys[2] = al;            
        }

        Greyhound[] greyhounds = new Greyhound[4];
        Guy[] guys = new Guy[3];

        Random rnd = new Random();
        
        private void btnStartRace_Click(object sender, EventArgs e)
        {
            foreach (Greyhound g in greyhounds)
                g.TakeStartingPosition();

            lblMinimumBet.Text = "All bets are OFF!";
            btnBets.Hide();

            timer1.Start();
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            if (lblBettorName.Text == "Joe")
            {
                guys[0].PlaceBet((int)numudBet.Value, (int)numudDogNumber.Value-1, greyhounds[(int)numudDogNumber.Value-1].Name);
            }
            if (lblBettorName.Text == "Bob")
            {
                guys[1].PlaceBet((int)numudBet.Value, (int)numudDogNumber.Value-1, greyhounds[(int)numudDogNumber.Value-1].Name);
            }
            if (lblBettorName.Text == "Al")
            {
                guys[2].PlaceBet((int)numudBet.Value, (int)numudDogNumber.Value-1, greyhounds[(int)numudDogNumber.Value-1].Name);
            }
        }

        private void rbtnJoe_CheckedChanged(object sender, EventArgs e)
        {
            lblBettorName.Text = "Joe";
        }

        private void rbtnBob_CheckedChanged(object sender, EventArgs e)
        {
            lblBettorName.Text = "Bob";
        }

        private void rbtnAl_CheckedChanged(object sender, EventArgs e)
        {
            lblBettorName.Text = "Al";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (greyhounds[i].Run(rnd.Next(5, 15)))
                {
                    timer1.Stop();
                    
                    if (MessageBox.Show(greyhounds[i].Name + " wins!") == DialogResult.OK)
                    {
                        foreach (Guy g in guys)
                        {
                            g.Collect(i);
                            g.ClearBet();
                        }

                        btnBets.Show();
                    }
                }
            }
        }
    }
}
