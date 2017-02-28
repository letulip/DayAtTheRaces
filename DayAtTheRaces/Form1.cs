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
        
        private void btnStartRace_Click(object sender, EventArgs e)
        {

            lblMinimumBet.Text = "All bets are OFF!";
            btnBets.Hide();
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
    }
}
