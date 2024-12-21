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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Car_Rental;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            String query = "Select * from customers";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];

            Con.Close();


        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Main_Form().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AddressTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into customers values('" + NameTb.Text + "','" + AddressTb.Text + "','" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Seccussfull added");

                    Con.Close();
                    populate();


                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
               IDTb.Text = "";
                NameTb.Text = "";
                AddressTb.Text = "";
                PhoneTb.Text = "";
            }
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTb.Text = CustomerDGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            AddressTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IDTb.Text == "" || NameTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update customers set CustName='" + NameTb.Text + "',CustAdd='" + AddressTb.Text + "',Phone='" + PhoneTb.Text + "'where Costid=" + IDTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Seccussfull Updated");

                    Con.Close();
                    populate();

                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IDTb.Text == "")
            {
                MessageBox.Show("commbulet data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from customers where Costid=" + IDTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Delete Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
                IDTb.Text = "";
                NameTb.Text = "";
                AddressTb.Text = "";
                PhoneTb.Text = "";

            }
        }
    }
}