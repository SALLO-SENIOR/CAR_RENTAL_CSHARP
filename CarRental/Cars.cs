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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Upass_OnValueChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Car_Rental;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            String query = "Select * from Cars";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];

            Con.Close();


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
             if (RegNumTb.Text == "" ||BrandTb.Text == "" || ModalTb.Text == ""|| PriceTb.Text=="")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Cars values('" + RegNumTb.Text + "' ,'" + BrandTb.Text + "','" + ModalTb.Text + "','" + AvailableCb.SelectedItem.ToString() + "','" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("carS Seccussfull added");

                    Con.Close();
                    populate();
                    
                    
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
                RegNumTb.Text = "";
                BrandTb.Text = "";
                ModalTb.Text = "";
                PriceTb.Text = "";
            }

        }

        private void Cars_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegNumTb.Text = CarsDGV.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = CarsDGV.SelectedRows[0].Cells[1].Value.ToString();
            ModalTb.Text = CarsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = CarsDGV.SelectedRows[0].Cells[4].Value.ToString();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "")
            {
                MessageBox.Show("commbulet data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from Cars where car_No=" + RegNumTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Delete Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
                RegNumTb.Text = "";
                BrandTb.Text = "";
                ModalTb.Text = "";
                PriceTb.Text = "";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModalTb.Text == "")
            {
                MessageBox.Show("fadlan xogta dhamastir");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update car set Brand='" + BrandTb.Text + "',Model='" + ModalTb.Text + "',Available='" + AvailableCb.SelectedItem + "',Price='" + PriceTb.Text + "'where car_No=" + RegNumTb.Text + ";";
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

        private void Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            string flag ="";
            if (Search.SelectedItem.ToString() == "Available")
            {
                flag = "Yes";
            }
            else
            {
                flag = "No";
            }
             Con.Open();
            String query = "Select * from Cars where Available='"+flag+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];

            Con.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
   

        }
    }
