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
    public partial class LiteracyRate : Form
    {
        public LiteracyRate()
        {
            InitializeComponent();
        }

        private void LiteracyRate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,name,f_name,education,cnic,city,province from tblEducation", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView7.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView7.Rows.Add();
                dataGridView7.Rows[n].Cells[0].Value = "false";
                dataGridView7.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView7.Rows[n].Cells[2].Value = item["name"].ToString();
                dataGridView7.Rows[n].Cells[3].Value = item["f_name"].ToString();
                dataGridView7.Rows[n].Cells[4].Value = item["education"].ToString();
                dataGridView7.Rows[n].Cells[5].Value = item["cnic"].ToString();
                dataGridView7.Rows[n].Cells[6].Value = item["city"].ToString();
                dataGridView7.Rows[n].Cells[7].Value = item["province"].ToString();
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into tblEducation(name,f_name,education,cnic,city,province)values(@name,@f_name,@education,@cnic,@city,@province)");
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@f_name", txtFatherName.Text);
            cmd.Parameters.AddWithValue("@education", txtEducation.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@province", txtProvince.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod7();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblEducation set name=@name,f_name=@f_name,education=@education,cnic=@cnic,city=@city,province=@province where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@f_name", txtFatherName.Text);
            cmd.Parameters.AddWithValue("@education", txtEducation.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@province", txtProvince.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod7();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblEducation where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod7();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface ir = new Interface();
            ir.Show();
            this.Hide();
        }


        void ResetMethod7()
        {
            txtCity.Clear();
            txtCNIC.Clear();
            txtEducation.Clear();
            txtFatherName.Clear();
            txtID.Clear();
            txtName.Clear();
            txtProvince.Clear();
        }
    }
}
