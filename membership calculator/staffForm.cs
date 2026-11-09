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
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            personalTrainerForm personalTrainer = new personalTrainerForm();
            personalTrainer.ShowDialog(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            trainerForm trainer = new trainerForm();
            trainer.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            instructorForm instructor = new instructorForm();
            instructor.ShowDialog(); 
        }
    }
}
