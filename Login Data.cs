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
    public partial class Login_Data : Form
    {
        public Login_Data()
        {
            InitializeComponent();
        }

        private void Login_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generation_Management_SystemDataSet.tblLoginData' table. You can move, or remove it, as needed.
            this.tblLoginDataTableAdapter.Fill(this.generation_Management_SystemDataSet.tblLoginData);

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,user_name,email,password,address,cnic,ph_no from tblLoginData", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView6.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView6.Rows.Add();
                dataGridView6.Rows[n].Cells[0].Value = "false";
                dataGridView6.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView6.Rows[n].Cells[2].Value = item["user_name"].ToString();
                dataGridView6.Rows[n].Cells[3].Value = item["email"].ToString();
                dataGridView6.Rows[n].Cells[4].Value = item["password"].ToString();
                dataGridView6.Rows[n].Cells[5].Value = item["address"].ToString();
                dataGridView6.Rows[n].Cells[6].Value = item["cnic"].ToString();
                dataGridView6.Rows[n].Cells[7].Value = item["ph_no"].ToString();
            }
        }

        private void btnSaverecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO tblLoginData ([user_name],[email],[password],[address],[cnic],[ph_no])VALUES(@user_name,@email,@password,@address,@cnic,@ph_no)");
            cmd.Parameters.AddWithValue("@user_name", txtUsername.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@ph_no", txtPhoneNO.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod2();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblLoginData set user_name=@user_name,email=@email,password=@password,address=@address,cnic=@cnic,ph_no=@ph_no where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@user_name", txtUsername.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@ph_no", txtPhoneNO.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod2();
        }

        private void btnDeleterecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblLoginData where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface ir = new Interface();
            ir.Show();
            this.Hide();
        }


        void ResetMethod2()
        {
            txtID.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtCNIC.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtPhoneNO.Clear();

        }
    }
}
