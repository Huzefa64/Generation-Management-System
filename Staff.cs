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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into tblStaff (staff_name,staff_f_name,email,cnic_no,ph_no,adress,staff_designition,staff_salary)values(@staff_name,@staff_f_name,@email,@cnic_no,@ph_no,@adress,@staff_designition,@staff_salary)");
            cmd.Parameters.AddWithValue("@staff_name", txtStaffName.Text);
            cmd.Parameters.AddWithValue("@staff_f_name", txtFatherName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@cnic_no", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@ph_no", txtPhoneNO.Text);
            cmd.Parameters.AddWithValue("@adress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@staff_designition", txtDesignition.Text);
            cmd.Parameters.AddWithValue("@staff_salary", txtSalary.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod3();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblStaff set staff_name=@staff_name,staff_f_name=@staff_f_name,email=@email,cnic_no=@cnic_no,ph_no=@ph_no,adress=@adress,staff_designition=@staff_designition,staff_salary=@staff_salary where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@staff_name", txtStaffName.Text);
            cmd.Parameters.AddWithValue("@staff_f_name", txtFatherName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@cnic_no", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@ph_no", txtPhoneNO.Text);
            cmd.Parameters.AddWithValue("@adress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@staff_designition", txtDesignition.Text);
            cmd.Parameters.AddWithValue("@staff_salary", txtSalary.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod3();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblStaff where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface ir = new Interface();
            ir.Show();
            this.Hide();
        }


        void ResetMethod3()
        {
            txtID.Clear();
            txtStaffName.Clear();
            txtFatherName.Clear();
            txtEmail.Clear();
            txtCNIC.Clear();
            txtPhoneNO.Clear();
            txtAddress.Clear();
            txtDesignition.Clear();
            txtSalary.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,staff_name,staff_f_name,email,cnic_no,ph_no,adress,staff_designition,staff_salary from tblStaff", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
               int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "false";
                dataGridView1.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["staff_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["staff_f_name"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["email"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["cnic_no"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["ph_no"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["adress"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["staff_designition"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["staff_salary"].ToString();
            }
        }
    }
}
