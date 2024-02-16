/*
 * Name: Chad Lutz
 * Date: April 2022
 * Description: ISM3232 Final Project 
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ISM3232_Final_Project
{
    public partial class FormConcertSeating : Form
    {
        public FormConcertSeating()
        {
            InitializeComponent();
        }

        // declare a list to hold string values, in case listBox doesn't count as a list for this assignment
        List<string> prices = new List<string>();

        // declare a currency variable to hold accumulated cost and initiate as zero
        decimal totalCost = 0m;

        // declare a whole number variable to hold accumulated seats and initiate as zero
        int totalSeats = 0;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // declare string variable to hold user input from text box
            string seatInput = textBoxSeatSection.Text;

            // initiate switch function for value of user input
            switch (seatInput)
            {
                // define each expected user input
                case "BLUE":
                    // when a user inputs BLUE and clicks Add to List, add noted string to list box
                    listBoxSeats.Items.Add("BLUE $128.50");

                    // also add noted string to prices list
                    prices.Add("BLUE $128.50");

                    // also add 1 to total seats count
                    totalSeats = totalSeats + 1;
                    break;
                case "GREEN":
                    // when a user inputs BLUE and clicks Add to List, add noted string to list box
                    listBoxSeats.Items.Add("GREEN $78.50");

                    // also add noted string to prices list
                    prices.Add("GREEN $78.50");

                    // also add 1 to total seats count
                    totalSeats = totalSeats + 1;
                    break;
                case "RED":
                    // when a user inputs BLUE and clicks Add to List, add noted string to list box
                    listBoxSeats.Items.Add("RED $62.50");

                    // also add noted string to prices list
                    prices.Add("RED $62.50");

                    // also add 1 to total seats count
                    totalSeats = totalSeats + 1;
                    break;
                case "YELLOW":
                    // when a user inputs BLUE and clicks Add to List, add noted string to list box
                    listBoxSeats.Items.Add("YELLOW $55.50");

                    // also add noted string to prices list
                    prices.Add("YELLOW $55.50");

                    // also add 1 to total seats count
                    totalSeats = totalSeats + 1;
                    break;
                default:
                    // if users enters anything not listed above, the following message displays
                    MessageBox.Show("Please enter valid seat section color: BLUE, RED, GREEN, YELLOW");
                    break;
            }
            // populate labelSeatCount output with accumulated totalSeats value
            labelSeatCount.Text = totalSeats.ToString();

            // alternate count method to populate labelSeatCount output
            //labelSeatCount.Text = listBoxSeats.Items.Count.ToString();
        }
        private void buttonTotal_Click(object sender, EventArgs e)
        {
            // alternate foreach loop using listBox rather than declared list
            //foreach (string x in listBoxSeats.Items)

            // begin foreach loop for string values in prices list
            foreach (string x in prices)

                // first condition of list item
                if (x == "BLUE $128.50")
                {
                    // if string matches, add value noted to totalCost
                    totalCost += 128.50m;
                }
                else if (x == "GREEN $78.50")
                {
                    // if string matches, add value noted to totalCost
                    totalCost += 78.50m;
                }
                else if (x == "RED $62.50")
                {
                    // if string matches, add value noted to totalCost
                    totalCost += 62.50m;
                }
                else
                {
                    // if string doesn't match any listed above, add value noted to totalCost
                    totalCost += 55.50m;
                }
            
            // populate labelCost field with dollar sign and value accumulated in totalCost parsed as string
            labelCost.Text = "$" + totalCost.ToString();

            // resets total cost to zero so each Total button click adds list values from zero
            totalCost = 0m;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clicking Clear button does all of this to reset the form
            // clear listBox
            listBoxSeats.Items.Clear();

            // clear prices list
            prices.Clear();

            // reset seatCount output label by defining it as zero
            labelSeatCount.Text = "0";

            // reset totalSeats count to zero
            totalSeats = 0;

            // reset total cost label by defining it as zero
            labelCost.Text = "$0";

            // reset total user input box for seat section by defining it as empty
            textBoxSeatSection.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // closes form
            this.Close();
        }

    }
}
