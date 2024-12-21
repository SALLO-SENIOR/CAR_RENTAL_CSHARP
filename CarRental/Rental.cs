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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Car_Rental;Integrated Security=True");
        private void Fillcombo()
        {
            Con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select car_No from Cars ", Con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            carRegTb.ValueMember= "car_No";
            carRegTb.DataSource= dt;
            Con.Close();
        }
        private void Fillcustomer()
        {
            Con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select id from Customers ", Con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            Custid.ValueMember = "id";
            Custid.DataSource = dt;
            Con.Close();
           
        }
        private void updateonRent()
        {
            Con.Open();
            string query = "update Cars set Available='" + "NO" + "'where car_No='" + carRegTb.SelectedValue.ToString() + "' ; ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Rental_Load(object sender, EventArgs e)
        {
            Fillcombo();
            Fillcustomer();
            populate();

        }
        private void fetchcustomername()
        {
            Con.Open();
            string queary = "select * from Customers where id='" + Custid.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(queary, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {

                CustnameTb.Text = dr["name"].ToString();
            }
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Main_Form().Show();
            this.Hide();
        }

        private void carRegTb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void Custid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchcustomername();
        }
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustnameTb.Text == "" || RentFeeTb.Text =="")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into rental values('" + carRegTb.SelectedValue.ToString() + "'," + idTb.Text + " ,'" + CustnameTb.Text + "','" + Rentdate.Text + "','" + Returndate.Text + "','" + RentFeeTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("car Seccussfull rented");

                    Con.Close();
                    populate();
                    updateonRent();


                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
                idTb.Text = "";
                carRegTb.Text = "";
                RentFeeTb.Text = "";
                CustnameTb.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (idTb.Text == "")
            {
                MessageBox.Show("commbulet data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from rental where id=" + idTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car rented Delete Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
                idTb.Text = "";
                CustnameTb.Text = "";
                RentFeeTb.Text = "";
                                
            }
        }

        private void idTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTb.Text = RentDGV.SelectedRows[0].Cells[0].Value.ToString();
            carRegTb.Text = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            Custid.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustnameTb.Text = RentDGV.SelectedRows[0].Cells[3].Value.ToString();
            Rentdate.Text = RentDGV.SelectedRows[0].Cells[4].Value.ToString();
            Returndate.Text = RentDGV.SelectedRows[0].Cells[5].Value.ToString();
            RentFeeTb.Text = RentDGV.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idTb.Text == "" || carRegTb.Text == "" || Custid.Text == "")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update rental set car_no='" + carRegTb.Text + "',cust_name='" + CustnameTb.Text + "',rental_date='" + Rentdate.Text + "',return_date='" + Returndate.Text + "',rent_fee='" + RentFeeTb.Text + "' where id='" + idTb.Text + "';";
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

        }

      
  }
