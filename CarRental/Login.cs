using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CarRental
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Car_Rental;Integrated Security=True");

        private void label5_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            Upass.Text = ""; 
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string querycar = "select Count(*) from users where username='"+Uname.Text+"' and password='"+Upass.Text+"'";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(querycar, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                new Main_Form().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password");
            
            }
            Con.Close();
        }
    }
}
