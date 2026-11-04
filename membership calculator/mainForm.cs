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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            membershipForm membership = new membershipForm();
            membership.ShowDialog();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            staffForm staff = new staffForm();
            staff.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void facilitiesButton_Click(object sender, EventArgs e)
        {
            facilitiesForm facilities = new facilitiesForm();
            facilities.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
