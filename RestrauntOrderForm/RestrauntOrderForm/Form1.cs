using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestrauntOrderForm
{
    public enum Prices { small = 3, large = 7, meat = 2, veg = 1, sause = 1 }

    public partial class Form1 : Form
    {
        //public vairables for calculating and displaying costs
        double SinglesubTotal = 0.00;
        double subTotal = 0.00;
        double taxRate = 0.13;
        double tax = 0.00;
        double total = 0.00;

        //public vairables for keeping track of the amount of subs each kind of toppings added
        int subs = 1;
        int meats = 0;
        int sauces = 0;
        int veg = 0;

        //string for keeping there name
        string Name;


        public Form1()
        {
            InitializeComponent();
        }


        //updates the diffrent costs
        private void updateCosts()
        {
            subTotal = SinglesubTotal * subs;
            tax = subTotal * taxRate;
            total = tax + subTotal;
        }


        //function to confirm your order
        private void Confirm()
        {
            //tells you your order info
            DialogResult result = MessageBox.Show(Name + "'s order:" + Environment.NewLine + subs + "sub(s) with," + Environment.NewLine + meats + " Meat(s)" + Environment.NewLine + veg + " veggie(s)" + Environment.NewLine + sauces + " sauce(s)" + Environment.NewLine + "for the price of " + total.ToString("$0.00"), "confirm", MessageBoxButtons.YesNo);

            //if you say yes confims it
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Your order has been submited!");
            }
        }


        //updates the labels that display costs
        private void updateLabels()
        {
            lblSubTotal.Text = subTotal.ToString("$0.00");
            lblTax.Text = tax.ToString("$0.00");
            lblTotal.Text = total.ToString("$0.00");
        }




        //bread types
        private void cbItalian_CheckedChanged(object sender, EventArgs e)
        {
            //if you choose Italian disables otherfbread types
            if (cbItalian.CheckState == CheckState.Checked)
            {
                cbHoneyO.Enabled = false;
                cbWholeG.Enabled = false;


            }
            //when deselected enables other choices again
            else if (cbItalian.CheckState == CheckState.Unchecked)
            {
                cbHoneyO.Enabled = true;
                cbWholeG.Enabled = true;
            }

            
        }


        private void cbWholeG_CheckedChanged(object sender, EventArgs e)
        {
            //if you choose Whole Grain disables otherfbread types
            if (cbWholeG.CheckState == CheckState.Checked)
            {
                cbHoneyO.Enabled = false;
                cbItalian.Enabled = false;


            }
            //when deselected enables other choices again
            else if (cbWholeG.CheckState == CheckState.Unchecked)
            {
                cbHoneyO.Enabled = true;
                cbItalian.Enabled = true;
            }

           
        }


        private void cbHoneyO_CheckedChanged(object sender, EventArgs e)
        {
            //if you choose Honey Oat disables otherfbread types
            if (cbHoneyO.CheckState == CheckState.Checked)
            {
                cbItalian.Enabled = false;
                cbWholeG.Enabled = false;


            }
            //when deselected enables other choices again
            else if (cbHoneyO.CheckState == CheckState.Unchecked)
            {
                cbItalian.Enabled = true;
                cbWholeG.Enabled = true;
            }

            
        }




        //Sizes
        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            //if 6inch chosen adds price
            if (rb6.Checked)
            {
                SinglesubTotal += (int)Prices.small;
            }

            //if 6inch unchosen removes price
            else
                SinglesubTotal -= (int)Prices.small;

            //updates costs and costlabels
            updateCosts();
            updateLabels();
        }


        private void rb12_CheckedChanged(object sender, EventArgs e)
        {
            //if 12inch chosen adds price
            if (rb12.Checked)
            {
                SinglesubTotal += (int)Prices.large;
            }

            //if 12inch unchosen removes price
            else
                SinglesubTotal -= (int)Prices.large;

            //updates costs and costlabels
            updateCosts();
            updateLabels();
        }




        //Meats
        private void cbTurkey_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            //adds or subtracts meat price when a meat is added or removed
            //records amount of meats for order summary
            if (cb.CheckState == CheckState.Checked)
            {
                SinglesubTotal += ((int)Prices.meat);
                meats++;
            }
            else if (cb.CheckState == CheckState.Unchecked)
            {
                meats--;
                SinglesubTotal -= ((int)Prices.meat);
            }

            //updates costs and costlabels
            updateCosts();
            updateLabels();
        }


        //veggies
        private void cbLettuce_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            //adds or subtracts veggie price when a veggie is added or removed
            //records amount of veggies for order summary
            if (cb.CheckState == CheckState.Checked)
            {
                SinglesubTotal += ((int)Prices.veg);
                veg++;
            }
            else if (cb.CheckState == CheckState.Unchecked)
            {
                SinglesubTotal -= ((int)Prices.veg);
                veg--;
            }
            //updates costs and costlabels
            updateCosts();
            updateLabels();
        }


        //sauces
        private void cbMayonnaise_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            //adds or subtracts sauce price when a sauce is added or removed
            //records amount of sauces for order summary
            if (cb.CheckState == CheckState.Checked)
            {
                SinglesubTotal += ((int)Prices.sause);
                sauces++;
            }
            else if (cb.CheckState == CheckState.Unchecked)
            {
                SinglesubTotal -= ((int)Prices.sause);
                sauces--;
            }
            //updates costs and costlabels
            updateCosts();
            updateLabels();
        }


        //when you submit it checkes to make sure all the needed data has been entered correctly 
        private void butSubmit_Click(object sender, EventArgs e)
        {
            //size is chosen?
            if (!rb6.Checked && !rb12.Checked)
            {
                MessageBox.Show("choose a size");
            }

            //bread has been chosen?
            else if (!cbItalian.Checked && !cbHoneyO.Checked && !cbWholeG.Checked)
            {
                MessageBox.Show("choose a bread");
            }

            //Toasted?
            else if (!rbYes.Checked && !rbNo.Checked)
            {
                MessageBox.Show("Toasted?");
            }

            //dilvery or pickup
            else if (!rbDelivery.Checked && !rbPickUp.Checked)
            {
                MessageBox.Show("Delivery or Pickup?");
            }

            //is an adress needed and if so is there one entered
            else if (rbDelivery.Checked && tbAdress.Text.Length < 1)
            {
                MessageBox.Show("enter an adress");
            }

            //is a name entered
            else if (tbName.Text.Length < 1)
            {
                MessageBox.Show("enter a name");
            }

            //has a ten digit number been entered
            else if (tbPhone.Text.Length != 14)
                MessageBox.Show("enter a ten digit phone number");

            else
            {
                //we know the number is 10 characters long, but is it only numbers
                //loop through the entire string in the textbox
                //if we find a non-number then let's  pop up a message box
                //check the specific spots for the format characters

                bool validNum = true;
                for (int i = 0; i < tbPhone.Text.Length; i++)
                {
                    //checking to see if the format is correct
                    if (i == 0)
                    {
                        //if its not a bracket its not valid
                        if (tbPhone.Text[0] != '(')
                            validNum = false;
                    }

                    else if (i == 4)
                    {
                        //if its not a bracket its not valid
                        if (tbPhone.Text[4] != ')')
                            validNum = false;
                    }

                    else if (i == 5)
                    {
                        if (tbPhone.Text[5] != '-')
                        {
                            validNum = false;
                        }
                    }

                    else if (i == 9)
                    {
                        if (tbPhone.Text[9] != '-')
                        {
                            validNum = false;
                        }
                    }

                    //checking if anything not for the format is a number
                    else if (!Char.IsNumber(tbPhone.Text[i]))
                        validNum = false;

                }

                //if anythig in the phone number is incorrect a message apears
                if (!validNum)
                {
                    MessageBox.Show("That's not a valid phone number");
                }
                //if eveything is corectly entered it pops up the summery and confirm window
                else
                    Confirm();

                

            }
        }


        //if your picking up dissables adress box
        private void rbPickUp_CheckedChanged(object sender, EventArgs e)
        {
            tbAdress.Enabled = false;

        }


        //if delivery enables the adress box
        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            tbAdress.Enabled = true;
        }


        //when the number up down is changed it updates the var
        private void nudSubs_ValueChanged(object sender, EventArgs e)
        {
            subs = (int)nudSubs.Value;

            //updates costs and costlabels
            updateCosts();
            updateLabels();
        }


        //clear button
        private void butClear_Click(object sender, EventArgs e)
        {
            // reset everything by destroying form and creating it new.
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);

        }


        //formats the phone number when you leave the textbox
        private void tbPhone_Leave(object sender, EventArgs e)
        {
            //turns the number you entered into a string
            string s = tbPhone.Text;
           
            //enters the correct formating characters into there locations
            s = s.Insert(0, "(");
            s = s.Insert(4, ")");
            s = s.Insert(5, "-");
            s = s.Insert(9, "-");

            //displays the now formated number in the tbox
            tbPhone.Text = s;
        }


        //when you leave the name tbox it updates the name var to what you entered
        private void tbName_Leave(object sender, EventArgs e)
        {
            Name = tbName.Text;
        }

       
    }
}
