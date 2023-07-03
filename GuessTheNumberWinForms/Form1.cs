using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();
            generateNumber();
            tries.Text = guesses.ToString();
        }

        private void generateNumber()
        {
            number = rnd.Next(0, 101);
        }

        private void guess_Click(object sender, EventArgs e)
        {
            if (int.Parse(zgadywanie.Text)==number)
            {
                MessageBox.Show("You win!\nNumber of tries: "+guesses+"\nLet's play again!","Hit and sunk");
                guesses = 0;
                tries.Text = guesses.ToString();
                zgadywanie.Text = "";
                generateNumber();
            }
            else if (int.Parse(zgadywanie.Text) < number)
            {
                guesses++;
                tries.Text = guesses.ToString();
                MessageBox.Show("It's too small of a number!", "Too big");
            }
            else if (int.Parse(zgadywanie.Text) > number)
            {
                guesses++;
                tries.Text = guesses.ToString();
                MessageBox.Show("It's too big of a number!", "Too small");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            guesses = 0;
            tries.Text = guesses.ToString();
            zgadywanie.Text = "";
            generateNumber();
        }

        private void zgadywanie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
