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
        }

        Greyhound[] greyhounds = new Greyhound[4];
        Random rnd = new Random();

        Guy joe = new Guy("Joe", 50);
        Guy bob = new Guy("Bob", 75);
        Guy al = new Guy("Al", 45);

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                greyhounds[i] = new Greyhound();
            }

            greyhounds[0].MyPictureBox = pbxLightning;
            greyhounds[1].MyPictureBox = pbxMcQuinn;
            greyhounds[2].MyPictureBox = pbxRabbitSlayer;
            greyhounds[3].MyPictureBox = pbxSantasLittleHelper;

            greyhounds[0].Name = "Lightning";
            greyhounds[1].Name = "McQuinn";
            greyhounds[2].Name = "RabbitSlayer";
            greyhounds[3].Name = "SantasLittleHelper";
            
            foreach (Greyhound g in greyhounds)
                g.TakeStartingPosition();

            lblMinimumBet.Text = "All bets are OFF!";
            btnBets.Hide();

            timer1.Start();
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            if(lblBettorName.Text == "Joe")
            {
                lblJoesBet.Text = "$ " + numudBet.Value.ToString() + " to dog No. " + numudDogNumber.Value.ToString();
            }
            if (lblBettorName.Text == "Bob")
            {
                lblBobsBet.Text = "$ " + numudBet.Value.ToString() + " to dog No. " + numudDogNumber.Value.ToString();
            }
            if (lblBettorName.Text == "Al")
            {
                lblAlsBet.Text = "$ " + numudBet.Value.ToString() + " to dog No. " + numudDogNumber.Value.ToString();
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
                    MessageBox.Show(greyhounds[i].Name + " wins!");
                }
                    
            }
        }
    }
}
