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
    public partial class FamilyPlanning : Form
    {
        public FamilyPlanning()
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
            SqlCommand cmd = new SqlCommand("insert into tblFamily_Planning(head,spouse_name,no_of_childern,family_no,cnic,child_gap)values(@head,@spouse_name,@no_of_childern,@family_no,@cnic,@child_gap)");
            cmd.Parameters.AddWithValue("@head", txtHead.Text);
            cmd.Parameters.AddWithValue("@spouse_name", txtSpouseName.Text);
            cmd.Parameters.AddWithValue("@no_of_childern", txtChildNo.Text);
            cmd.Parameters.AddWithValue("@family_no", txtFamilyNo.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@child_gap", txtChildGap.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod9();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblFamily_Planning set head=@head,spouse_name=@spouse_name,no_of_childern=@no_of_childern,family_no=@family_no,cnic=@cnic,child_gap=@child_gap where id=@id");
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@head", txtHead.Text);
            cmd.Parameters.AddWithValue("@spouse_name", txtSpouseName.Text);
            cmd.Parameters.AddWithValue("@no_of_childern", txtChildNo.Text);
            cmd.Parameters.AddWithValue("@family_no", txtFamilyNo.Text);
            cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text);
            cmd.Parameters.AddWithValue("@child_gap", txtChildGap.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod9();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblFamily_Planning where id=@id");
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod9();
        }


        void ResetMethod9()
        {
            txtChildGap.Clear();
            txtChildNo.Clear();
            txtCNIC.Clear();
            txtFamilyNo.Clear();
            txtHead.Clear();
            txtId.Clear();
            txtSpouseName.Clear();
        }

        private void FamilyPlanning_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,head,spouse_name,no_of_childern,family_no,cnic,child_gap from tblFamily_Planning", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView9.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView9.Rows.Add();
                dataGridView9.Rows[n].Cells[0].Value = "false";
                dataGridView9.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView9.Rows[n].Cells[2].Value = item["head"].ToString();
                dataGridView9.Rows[n].Cells[3].Value = item["spouse_name"].ToString();
                dataGridView9.Rows[n].Cells[4].Value = item["no_of_childern"].ToString();
                dataGridView9.Rows[n].Cells[5].Value = item["family_no"].ToString();
                dataGridView9.Rows[n].Cells[6].Value = item["cnic"].ToString();
                dataGridView9.Rows[n].Cells[7].Value = item["child_gap"].ToString();
            }
        }
    }
}
