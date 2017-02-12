using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Concatenation
{
    public partial class Concatenation : Form
    {
        public Concatenation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtCity.Clear();
            txtCountry.Clear();
        }

        private void btnBirthPlace_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtFirst.Text + " " + txtLast.Text +
                " was born in " + txtCity.Text + ", " + txtCountry.Text + ".";
        }

        private void btnPlaceYear_Click(object sender, EventArgs e)
        {
            string strYear = Interaction.InputBox(
                txtFirst.Text + ", what year were you born?");
            txtOutput.Text = "in " + strYear + ", " + txtFirst.Text +
                " " + txtLast.Text + " was born in " + txtCity.Text +
                ", " + txtCountry.Text + ".";
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            string strName = Interaction.InputBox("What is your name?");
            string strLunch = Interaction.InputBox("Hi, " + strName +
                ", what did you have for lunch?");
            txtOutput.Text = strName + " had " + strLunch + " for lunch.";
        }

        private void btnNewLines_Click(object sender, EventArgs e)
        {
            txtOutput.Text = ControlChars.Tab + "Store Hours" +
                Environment.NewLine + Environment.NewLine +
                "Monday to Friday: 10:00am to 10:00pm" + Environment.NewLine +
                "Saturday: 12:00pm to 19:00pm" + Environment.NewLine +
                "Sunday: Closed"; 
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            string strName = Interaction.InputBox("What is your name?");
            string strDrink = Interaction.InputBox("What is your favorite drink?");
            string strFood = Interaction.InputBox("What is your favorite food?");
            string strMovie = Interaction.InputBox("What is your favorite movie?");
            txtOutput.Text = strName + " enjoys watching " + strMovie + " while drinking " +
                strDrink + " and eating " + strFood + "."; 
        }

        private void btnAfternoon_Click(object sender, EventArgs e)
        {
            string strName = Interaction.InputBox("What is your name?");
            string strPlace = Interaction.InputBox("Hi " + strName +
                ". where were you this afternoon?");
            txtOutput.Text = strName + " was at/in " + strPlace + " this afternoon.";
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            string strModel = Interaction.InputBox("What type of phone do you have?");
            string strPrice = Interaction.InputBox("How much did you pay for it?");
            txtOutput.Text = "You have paid $" + strPrice + " for a " + strModel + ".";
        }
    }
}
