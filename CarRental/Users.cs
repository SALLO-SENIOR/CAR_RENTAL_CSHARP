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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Car_Rental;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            String query = "Select * from users";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UsersDGV.DataSource = ds.Tables[0];

            Con.Close();


        }
        private void Users_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into users values(" + Uid.Text + " ,'" + Uname.Text + "','" + Upass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Seccussfull added");

                    Con.Close();
                    populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }

        }

        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "")
            {
                MessageBox.Show("commbulet data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from users where id=" + Uid.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Delete Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
                Uid.Text = "";
                Uname.Text = "";
                Upass.Text = "";
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uid.Text = UsersDGV.SelectedRows[0].Cells[0].Value.ToString();
            Uname.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            Upass.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update users set Uname='" + Uname.Text + "',Upass='" + Upass.Text + "'where id=" + Uid.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Seccussfull Updated");

                    Con.Close();
                    populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main_Form().Show();
        }
    }

}