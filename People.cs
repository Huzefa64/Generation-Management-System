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
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        private void People_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generation_Management_SystemDataSet4.tblPeople' table. You can move, or remove it, as needed.
            this.tblPeopleTableAdapter.Fill(this.generation_Management_SystemDataSet4.tblPeople);

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,name,f_name,cnic,phone_no,head,total_members,adress,city,province,family_no,material_status,gender,religion from tblPeople", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView5.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView5.Rows.Add();
                dataGridView5.Rows[n].Cells[0].Value = "false";
                dataGridView5.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView5.Rows[n].Cells[2].Value = item["name"].ToString();
                dataGridView5.Rows[n].Cells[3].Value = item["f_name"].ToString();
                dataGridView5.Rows[n].Cells[4].Value = item["cnic"].ToString();
                dataGridView5.Rows[n].Cells[5].Value = item["phone_no"].ToString();
                dataGridView5.Rows[n].Cells[6].Value = item["head"].ToString();
                dataGridView5.Rows[n].Cells[7].Value = item["total_members"].ToString();
                dataGridView5.Rows[n].Cells[8].Value = item["adress"].ToString();
                dataGridView5.Rows[n].Cells[9].Value = item["city"].ToString();
                dataGridView5.Rows[n].Cells[10].Value = item["province"].ToString();
                dataGridView5.Rows[n].Cells[11].Value = item["family_no"].ToString();
                dataGridView5.Rows[n].Cells[12].Value = item["material_status"].ToString();
                dataGridView5.Rows[n].Cells[13].Value = item["gender"].ToString();
                dataGridView5.Rows[n].Cells[14].Value = item["religion"].ToString();
            }

        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into tblPeople (name,f_name,cnic,phone_no,head,total_members,adress,city,province,family_no,material_status,gender,religion)values(@name,@f_name,@cnic,@phone_no,@head,@total_members,@adress,@city,@province,@family_no,@material_status,@gender,@religion)");
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@f_name", txtFthrName.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@phone_no", txtPhoneNo.Text);
            cmd.Parameters.AddWithValue("@head", txtHead.Text);
            cmd.Parameters.AddWithValue("@total_members", txtTMembers.Text);
            cmd.Parameters.AddWithValue("@adress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@province", txtProvince.Text);
            cmd.Parameters.AddWithValue("@family_no", txtFamilyNo.Text);
            cmd.Parameters.AddWithValue("@material_status", txtMaterialSts.Text);
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@religion", txtReligion.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod6();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblPeople set name=@name,f_name=@f_name,cnic=@cnic,phone_no=@phone_no,head=@head,total_members=@total_members,adress=@adress,city=@city,province=@province,family_no=@family_no,material_status=@material_status,gender=@gender,religion=@religion where id=@id");
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@f_name", txtFthrName.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@phone_no", txtPhoneNo.Text);
            cmd.Parameters.AddWithValue("@head", txtHead.Text);
            cmd.Parameters.AddWithValue("@total_members", txtTMembers.Text);
            cmd.Parameters.AddWithValue("@adress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@province", txtProvince.Text);
            cmd.Parameters.AddWithValue("@family_no", txtFamilyNo.Text);
            cmd.Parameters.AddWithValue("@material_status", txtMaterialSts.Text);
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@religion", txtReligion.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod6();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblPeople where id=@id");
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod6();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface ir = new Interface();
            ir.Show();
            this.Hide();
        }


        void ResetMethod6()
        {
            txtAddress.Clear();
            txtCity.Clear();
            txtCNIC.Clear();
            txtFamilyNo.Clear();
            txtFthrName.Clear();
            txtGender.Clear();
            txtHead.Clear();
            txtId.Clear();
            txtMaterialSts.Clear();
            txtName.Clear();
            txtPhoneNo.Clear();
            txtProvince.Clear();
            txtReligion.Clear();
            txtTMembers.Clear();
        }
    }
}
