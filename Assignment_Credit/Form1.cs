using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Credit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pic_1p_Click(object sender, EventArgs e)

        {

            if ((txt_enter.Text) == "0" || txt_enter.Text == "" ) // if the text box "txt_enter" equals 0 or is null then
            {
                MessageBox.Show("You have not set the Cost of a Credit"); // display a message box stating that the user have not set the credit 
            }
            else
            {
                int hold_number = Convert.ToInt32(lbl_amount.Text); // hold the value on the label named "lbl_amount"
                hold_number = hold_number + 1; // when the "pic_1p" is clicked the label increments by 1 
                lbl_amount.Text = hold_number.ToString(); 
            }
          
        }

        private void grp_entered_Enter(object sender, EventArgs e)
        {

        }

        private void txt_enter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pic_2p_Click(object sender, EventArgs e)
        {
            if ((txt_enter.Text) == "0" || txt_enter.Text == "") // if the text box "txt_enter" equals 0 or is null then
            {
                MessageBox.Show("You have not set the Cost of a Credit"); // display a message box stating that the user have not set the credit 
            }
            else
            {
                int hold_number = Convert.ToInt32(lbl_amount1.Text); // hold the value on the label named "lbl_amount"
                hold_number = hold_number + 1; // when the "pic_2p" is clicked the label increments by 1 
                lbl_amount1.Text = hold_number.ToString();
            }
        }

        private void pic_5p_Click(object sender, EventArgs e)
        {
            if ((txt_enter.Text) == "0" || txt_enter.Text == "") // if the text box "txt_enter" equals 0 or is null then
            {
                MessageBox.Show("You have not set the Cost of a Credit"); // display a message box stating that the user have not set the credit 
            }
            else
            {
                int hold_number = Convert.ToInt32(lbl_amount2.Text); // hold the value on the label named "lbl_amount"
                hold_number = hold_number + 1; // when the "pic_5p" is clicked the label increments by 1
                lbl_amount2.Text = hold_number.ToString();
            }
        }

        private void pic_10p_Click(object sender, EventArgs e)
        {
            if ((txt_enter.Text) == "0" || txt_enter.Text == "") // if the text box "txt_enter" equals 0 or is null then
            {
                MessageBox.Show("You have not set the Cost of a Credit"); // display a message box stating that the user have not set the credit 
            }
            else
            {
                int hold_number = Convert.ToInt32(lbl_amount3.Text); // hold the value on the label named "lbl_amount"
                hold_number = hold_number + 1; // when the "pic_10p" is clicked the label increment by 1 
                lbl_amount3.Text = hold_number.ToString();
            }
        }

        private void pic_20p_Click(object sender, EventArgs e)
        {
            if ((txt_enter.Text) == "0" || txt_enter.Text == "") // if the text box "txt_enter" equals 0 or is null then
            {
                MessageBox.Show("You have not set the Cost of a Credit"); // display a message box stating that the user have not set the credit 
            }
            else
            {
                int hold_number = Convert.ToInt32(lbl_amount4.Text); // hold the value on the label named "lbl_amount"
                hold_number = hold_number + 1; // when the "pic_20p" is clicked the label increment by 1 
                lbl_amount4.Text = hold_number.ToString();
            }
        }

        private void pic_50p_Click(object sender, EventArgs e)
        {
            if ((txt_enter.Text) == "0" || txt_enter.Text == "") // if the text box "txt_enter" equals 0 or is null then
            {
                MessageBox.Show("You have not set the Cost of a Credit"); // display a message box stating that the user have not set the credit 
            }
            else
            {
                int hold_number = Convert.ToInt32(lbl_amount5.Text); // hold the value on the label named "lbl_amount"
                hold_number = hold_number + 1; // when the "pic_50p" is clicked the label increment by 1 
                lbl_amount5.Text = hold_number.ToString();
            }
        }

        private void pic_1pound_Click(object sender, EventArgs e)
        {
            if ((txt_enter.Text) == "0" || txt_enter.Text == "") // if the text box "txt_enter" equals 0 or is null then
            {
                MessageBox.Show("You have not set the Cost of a Credit"); // display a message box stating that the user have not set the credit 
            }
            else
            {
                int hold_number = Convert.ToInt32(lbl_amount6.Text); // hold the value on the label named "lbl_amount"
                hold_number = hold_number + 1; // when the "pic_1pound" is clicked the label increment by 1 
                lbl_amount6.Text = hold_number.ToString();
            }
        }

        private void pic_2pound_Click(object sender, EventArgs e)
        {
            if ((txt_enter.Text) == "0" || txt_enter.Text == "") // if the text box "txt_enter" equals 0 or is null then
            {
                MessageBox.Show("You have not set the Cost of a Credit"); // display a message box stating that the user have not set the credit 
            }
            else
            {
                int hold_number = Convert.ToInt32(lbl_amount7.Text); // hold the value on the label named "lbl_amount"
                hold_number = hold_number + 1; // when the "pic_1pound" is clicked the label increment by 1 
                lbl_amount7.Text = hold_number.ToString();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_enter.Clear(); // cleared all the text boxes 
            txt_number.Clear();
            txt_credits.Clear();
            txt_total.Clear();
            lbl_amount.Text = "0"; // set all the labels to "0"
            lbl_amount1.Text = "0";
            lbl_amount2.Text = "0";
            lbl_amount3.Text = "0";
            lbl_amount4.Text = "0";
            lbl_amount5.Text = "0";
            lbl_amount6.Text = "0"; 
        }
    }
}
