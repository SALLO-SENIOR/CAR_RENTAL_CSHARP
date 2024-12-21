using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Users().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cars().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Rental().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Return().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Dashbord().Show();
            this.Hide();
        }
    }
}
