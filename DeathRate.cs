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
    public partial class DeathRate : Form
    {
        public DeathRate()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("insert into tblDead_People(total_members,family_no,dead_people,dead_name,cnic,death_certaficate,birth_date,death_date)values(@total_members,@family_no,@dead_people,@dead_name,@cnic,@death_certaficate,@birth_date,@death_date)");
            cmd.Parameters.AddWithValue("@total_members", txtTMembers.Text);
            cmd.Parameters.AddWithValue("@family_no", txtFamilyNo.Text);
            cmd.Parameters.AddWithValue("@dead_people", txtDeadPeople.Text);
            cmd.Parameters.AddWithValue("@dead_name", txtName.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@death_certaficate", txtDeathCerti.Text);
            cmd.Parameters.AddWithValue("@birth_date", txtBirthRate.Text);
            cmd.Parameters.AddWithValue("@death_date", txtDeathDate.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod10();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblDead_People set total_members=@total_members,family_no=@family_no,dead_people=@dead_people,dead_name=@dead_name,cnic=@cnic,death_certaficate=@death_certaficate,birth_date=@birth_date,death_date=@death_date where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@total_members", txtTMembers.Text);
            cmd.Parameters.AddWithValue("@family_no", txtFamilyNo.Text);
            cmd.Parameters.AddWithValue("@dead_people", txtDeadPeople.Text);
            cmd.Parameters.AddWithValue("@dead_name", txtName.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@death_certaficate", txtDeathCerti.Text);
            cmd.Parameters.AddWithValue("@birth_date", txtBirthRate.Text);
            cmd.Parameters.AddWithValue("@death_date", txtDeathDate.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod10();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblDead_People where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod10();
        }


        void ResetMethod10()
        {
            txtBirthRate.Clear();
            txtCNIC.Clear();
            txtDeadPeople.Clear();
            txtDeathCerti.Clear();
            txtDeathDate.Clear();
            txtFamilyNo.Clear();
            txtID.Clear();
            txtName.Clear();
            txtTMembers.Clear();
        }

        private void DeathRate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,total_members,family_no,dead_people,dead_name,cnic,death_certaficate,birth_date,death_date from tblDead_People", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView10.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView10.Rows.Add();
                dataGridView10.Rows[n].Cells[0].Value = "false";
                dataGridView10.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView10.Rows[n].Cells[2].Value = item["total_members"].ToString();
                dataGridView10.Rows[n].Cells[3].Value = item["family_no"].ToString();
                dataGridView10.Rows[n].Cells[4].Value = item["dead_people"].ToString();
                dataGridView10.Rows[n].Cells[5].Value = item["dead_name"].ToString();
                dataGridView10.Rows[n].Cells[6].Value = item["cnic"].ToString();
                dataGridView10.Rows[n].Cells[7].Value = item["death_certaficate"].ToString();
                dataGridView10.Rows[n].Cells[8].Value = item["birth_date"].ToString();
                dataGridView10.Rows[n].Cells[9].Value = item["death_date"].ToString();
            }
        }
    }
}
