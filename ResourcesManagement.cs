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
    public partial class ResourcesManagement : Form
    {
        public ResourcesManagement()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("insert into tblRes_Percentage(inc_population,economy_perce,resources_per,birth_rate,death_rate)values(@inc_population,@economy_perce,@resources_per,@birth_rate,@death_rate)");
            cmd.Parameters.AddWithValue("@inc_population", txtIncPopulation.Text);
            cmd.Parameters.AddWithValue("@economy_perce", txtEcoPer.Text);
            cmd.Parameters.AddWithValue("@resources_per", txtResPer.Text);
            cmd.Parameters.AddWithValue("@birth_rate", txtBirthRate.Text);
            cmd.Parameters.AddWithValue("@death_rate", txtDeathRate.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod4();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblRes_Percentage set inc_population=@inc_population,economy_perce=@economy_perce,resources_per=@resources_per,birth_rate=@birth_rate,death_rate=@death_rate where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@inc_population", txtIncPopulation.Text);
            cmd.Parameters.AddWithValue("@economy_perce", txtEcoPer.Text);
            cmd.Parameters.AddWithValue("@resources_per", txtResPer.Text);
            cmd.Parameters.AddWithValue("@birth_rate", txtBirthRate.Text);
            cmd.Parameters.AddWithValue("@death_rate", txtDeathRate.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod4();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblRes_Percentage where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod4();
        }


        void ResetMethod4()
        {
            txtBirthRate.Clear();
            txtDeathRate.Clear();
            txtEcoPer.Clear();
            txtID.Clear();
            txtIncPopulation.Clear();
            txtResPer.Clear();
        }

        private void ResourcesManagement_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,inc_population,economy_perce,resources_per,birth_rate,death_rate from tblRes_Percentage", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = "false";
                dataGridView3.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView3.Rows[n].Cells[2].Value = item["inc_population"].ToString();
                dataGridView3.Rows[n].Cells[3].Value = item["economy_perce"].ToString();
                dataGridView3.Rows[n].Cells[4].Value = item["resources_per"].ToString();
                dataGridView3.Rows[n].Cells[5].Value = item["birth_rate"].ToString();
                dataGridView3.Rows[n].Cells[6].Value = item["death_rate"].ToString();
            }
        }
    }
}
