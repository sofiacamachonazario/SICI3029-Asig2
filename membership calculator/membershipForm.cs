using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace membership_calculator
{
    public partial class membershipForm : Form
    {
        public membershipForm()
        {
            InitializeComponent();
        }

        private void membershipGroupBox_Enter(object sender, EventArgs e)
        {

        }      
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void childButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void studentButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void seniorButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void option_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void yoga_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void karate_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void personal_Trainer_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void membership_Length_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void enter_Name_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fees_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void monthly_Fee_Label_Click(object sender, EventArgs e)
        {

        }

        private void total_Label_Click(object sender, EventArgs e)
        {

        }

        private void calculate_button_Click(object sender, EventArgs e)
        {

        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            //Limpiar TextBox
            lengthTextbox.Text = String.Empty;

            //limpiar Labels
            monthlyfee_label.Text = " ";
            total.Text = " ";

            //Clear RadioButtons
            standardAdultButton.Checked = false;
            childButton.Checked = false;
            studentButton.Checked = false;
            seniorButton.Checked = false;

            //Clear CheckBoxes
            trainerCheckbox.Checked = false;
            instructorCheckbox.Checked = false;
            personalTrainerCheckbox.Checked = false;





        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthlyfee_label_Click(object sender, EventArgs e)
        {

        }
    }
}
