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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Car_Rental;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            String query = "Select * from rental";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentDGV.DataSource = ds.Tables[0];

            Con.Close();

        }
        private void populate1()
        {
            Con.Open();
            String query = "Select * from return_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnDVG.DataSource = ds.Tables[0];

            Con.Close();

        }
        private void deleteonreturn()
        {
            int rentId;
            rentId = Convert.ToInt32(RentDGV.SelectedRows[0].Cells[0].Value.ToString());

            Con.Open();
            string Query = "Delete from customers where Costid=" + rentId + ";";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Customer Delete Successfully");
            Con.Close();
            //populate();
        
        }

        private void Return_Load(object sender, EventArgs e)
        {
            populate();
            populate1();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Main_Form().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CaridTb.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustnameTb.Text = RentDGV.SelectedRows[0].Cells[3].Value.ToString();
            Returndate.Text = RentDGV.SelectedRows[0].Cells[5].Value.ToString();
            DateTime d1 = Returndate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrQfDays = Convert.ToInt32(t.TotalDays);
            if (NrQfDays <= 0)
            {
                DelayTb.Text = "No delay";
                fineTb.Text = "No fine";
            }
            else
            {
                DelayTb.Text = "" + NrQfDays;
                fineTb.Text = ("" + NrQfDays * 5);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (idTb.Text == "" || CustnameTb.Text == "" || Returndate.Text =="")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into return_tbl values(" + idTb.Text + " ,'" + CaridTb.Text + "','" + CustnameTb.Text + "','" + Returndate.Text + "','" + DelayTb.Text + "','" + fineTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("car Dully Returned");

                    Con.Close();
                    
                    //updateonRent();
                    populate1();
                  


                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
                idTb.Text = "";
               CustnameTb.Text = "";
                DelayTb.Text = "";
                fineTb.Text = "";
            }
        }

        }


    }