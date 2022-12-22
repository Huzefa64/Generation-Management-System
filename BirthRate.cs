using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generation_Management_System
{
    public partial class BirthRate : Form
    {
        public BirthRate()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface ir = new Interface();
            ir.Show();
            this.Hide();
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into tblBirth(family_no,baby_name,date_of_birth,assign_b_no)values(@family_no,@baby_name,@date_of_birth,@assign_b_no)");
            cmd.Parameters.AddWithValue("@family_no", txtFamilyNO.Text);
            cmd.Parameters.AddWithValue("@baby_name", txtChildName.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", txtDOB.Text);
            cmd.Parameters.AddWithValue("@assign_b_no", txtCNIC.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod11();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblBirth set family_no=@family_no,baby_name=@baby_name,date_of_birth=@date_of_birth,assign_b_no=@assign_b_no where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@family_no", txtFamilyNO.Text);
            cmd.Parameters.AddWithValue("@baby_name", txtChildName.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", txtDOB.Text);
            cmd.Parameters.AddWithValue("@assign_b_no", txtCNIC.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod11();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblBirth where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod11();
        }


        void ResetMethod11()
        {
            txtChildName.Clear();
            txtCNIC.Clear();
            txtDOB.Clear();
            txtFamilyNO.Clear();
            txtID.Clear();
        }

        private void BirthRate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,family_no,baby_name,date_of_birth,assign_b_no from tblBirth", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = "false";
                dataGridView2.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item["family_no"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item["baby_name"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item["date_of_birth"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item["assign_b_no"].ToString();
            }
        }
    }
}
