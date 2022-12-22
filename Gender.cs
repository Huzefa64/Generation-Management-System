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
    public partial class Gender : Form
    {
        public Gender()
        {
            InitializeComponent();
        }

        private void Gender_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generation_Management_SystemDataSet2.tblGender' table. You can move, or remove it, as needed.
            this.tblGenderTableAdapter1.Fill(this.generation_Management_SystemDataSet2.tblGender);
            // TODO: This line of code loads data into the 'generation_Management_SystemDataSet1.tblGender' table. You can move, or remove it, as needed.
            //this.tblGenderTableAdapter.Fill(this.generation_Management_SystemDataSet1.tblGender);

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,gender,lesbians,gay,other,straight,married,religion from tblGender", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView8.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView8.Rows.Add();
                dataGridView8.Rows[n].Cells[0].Value = "false";
                dataGridView8.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView8.Rows[n].Cells[2].Value = item["gender"].ToString();
                dataGridView8.Rows[n].Cells[3].Value = item["lesbians"].ToString();
                dataGridView8.Rows[n].Cells[4].Value = item["gay"].ToString();
                dataGridView8.Rows[n].Cells[5].Value = item["other"].ToString();
                dataGridView8.Rows[n].Cells[6].Value = item["straight"].ToString();
                dataGridView8.Rows[n].Cells[7].Value = item["married"].ToString();
                dataGridView8.Rows[n].Cells[8].Value = item["religion"].ToString();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tblGender] ([gender],[lesbians],[gay],[other],[straight],[married],[religion])VALUES(@gender,@lesbians,@gay,@other,@straight,@married,@religion)");
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@lesbians", txtLessbian.Text);
            cmd.Parameters.AddWithValue("@gay", txtGay.Text);
            cmd.Parameters.AddWithValue("@other", txtOther.Text);
            cmd.Parameters.AddWithValue("@straight", txtStraight.Text);
            cmd.Parameters.AddWithValue("@married", txtMarried.Text);
            cmd.Parameters.AddWithValue("@religion", txtReligion.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod8();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblGender set gender=@gender,lesbians=@lesbians,gay=@gay,other=@other,straight=@straight,married=@married,religion=@religion where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@lesbians", txtLessbian.Text);
            cmd.Parameters.AddWithValue("@gay", txtGay.Text);
            cmd.Parameters.AddWithValue("@other", txtOther.Text);
            cmd.Parameters.AddWithValue("@straight", txtStraight.Text);
            cmd.Parameters.AddWithValue("@married", txtMarried.Text);
            cmd.Parameters.AddWithValue("@religion", txtReligion.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod8();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblGender where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod8();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface ir = new Interface();
            ir.Show();
            this.Hide();
        }


        void ResetMethod8()
        {
            txtGay.Clear();
            txtGender.Clear();
            txtID.Clear();
            txtLessbian.Clear();
            txtMarried.Clear();
            txtOther.Clear();
            txtReligion.Clear();
            txtStraight.Clear();
        }
    }
}
