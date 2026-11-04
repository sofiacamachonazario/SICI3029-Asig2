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
            // Tarifas mensuales de membresia
            decimal adultFee = 40.00m;
            decimal childFee = 20.00m;
            decimal studentFee = 25.00m;
            decimal seniorFee = 30.00m;

            // Tarifas mensuales de servicios opcionales
            decimal trainerFee = 10.00m;          // Karate (Trainers)
            decimal instructorFee = 30.00m;       // Pilates (Instructors)
            decimal personalTrainerFee = 50.00m;   // Entrenador Personal

            int months;
            decimal monthlyFee = 0.00m;
            decimal totalFee;

            // Validar nombre y apellido
            if (nameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your first name.", "Input Error");
                nameTextBox.Focus();
                return;
            }
            if (lastnametextbox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your last name.", "Input Error");
                lastnametextbox.Focus();
                return;
            }

            // Validar que se haya seleccionado un tipo de membresia
            if (!standardAdultButton.Checked && !childButton.Checked &&
                !studentButton.Checked && !seniorButton.Checked)
            {
                MessageBox.Show("Please select a membership type.", "Input Error");
                standardAdultButton.Focus();
                return;
            }

            // Validar que los meses sean un numero entero entre 1 y 24
            if (!int.TryParse(lengthTextbox.Text, out months))
            {
                MessageBox.Show("Please enter a numeric whole number for the membership length.", "Input Error");
                lengthTextbox.Focus();
                lengthTextbox.SelectAll();
                return;
            }
            if (months < 1 || months > 24)
            {
                MessageBox.Show("Membership length must be between 1 and 24 months.", "Input Error");
                lengthTextbox.Focus();
                lengthTextbox.SelectAll();
                return;
            }

            // Calcular el cargo mensual segun la membresia seleccionada
            if (standardAdultButton.Checked)
                monthlyFee = adultFee;
            else if (childButton.Checked)
                monthlyFee = childFee;
            else if (studentButton.Checked)
                monthlyFee = studentFee;
            else if (seniorButton.Checked)
                monthlyFee = seniorFee;

            // Sumar los servicios opcionales seleccionados
            if (trainerCheckbox.Checked)
                monthlyFee += trainerFee;
            if (instructorCheckbox.Checked)
                monthlyFee += instructorFee;
            if (personalTrainerCheckbox.Checked)
                monthlyFee += personalTrainerFee;

            // Calcular el total para el periodo seleccionado
            totalFee = monthlyFee * months;

            monthlyfee_label.Text = monthlyFee.ToString("C2");
            total.Text = totalFee.ToString("C2");
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            //Limpiar TextBox
            lengthTextbox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            lastnametextbox.Text = String.Empty;


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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
