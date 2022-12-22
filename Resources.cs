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
    public partial class Resources : Form
    {
        public Resources()
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
            SqlCommand cmd = new SqlCommand("insert into tblResources(water_res,food_res,import_export,elec_res,agri_res,allocted_res)values(@water_res,@food_res,@import_export,@elec_res,@agri_res,@allocted_res)");
            cmd.Parameters.AddWithValue("@water_res", txtWaterRes.Text);
            cmd.Parameters.AddWithValue("@food_res", txtFoodRes.Text);
            cmd.Parameters.AddWithValue("@import_export", txtImpExp.Text);
            cmd.Parameters.AddWithValue("@elec_res", txtElectricRes.Text);
            cmd.Parameters.AddWithValue("@agri_res", txtAgriRes.Text);
            cmd.Parameters.AddWithValue("@allocted_res", txtAlloctedRes.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully...");
            con.Close();
            ResetMethod5();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update tblResources set water_res=@water_res,food_res=@food_res,import_export=@import_export,elec_res=@elec_res,agri_res=@agri_res,allocted_res=@allocted_res where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@water_res", txtWaterRes.Text);
            cmd.Parameters.AddWithValue("@food_res", txtFoodRes.Text);
            cmd.Parameters.AddWithValue("@import_export", txtImpExp.Text);
            cmd.Parameters.AddWithValue("@elec_res", txtElectricRes.Text);
            cmd.Parameters.AddWithValue("@agri_res", txtAgriRes.Text);
            cmd.Parameters.AddWithValue("@allocted_res", txtAlloctedRes.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully...");
            con.Close();
            ResetMethod5();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from tblResources where id=@id");
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete Successfully...");
            con.Close();
            ResetMethod5();
        }


        void ResetMethod5()
        {
            txtID.Clear();
            txtImpExp.Clear();
            txtWaterRes.Clear();
            txtFoodRes.Clear();
            txtElectricRes.Clear();
            txtAlloctedRes.Clear();
            txtAgriRes.Clear();
        }

        private void Resources_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Generation_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select id,water_res,food_res,import_export,elec_res,agri_res,allocted_res from tblResources", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView4.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView4.Rows.Add();
                dataGridView4.Rows[n].Cells[0].Value = "false";
                dataGridView4.Rows[n].Cells[1].Value = item["id"].ToString();
                dataGridView4.Rows[n].Cells[2].Value = item["water_res"].ToString();
                dataGridView4.Rows[n].Cells[3].Value = item["food_res"].ToString();
                dataGridView4.Rows[n].Cells[4].Value = item["import_export"].ToString();
                dataGridView4.Rows[n].Cells[5].Value = item["elec_res"].ToString();
                dataGridView4.Rows[n].Cells[6].Value = item["agri_res"].ToString();
                dataGridView4.Rows[n].Cells[7].Value = item["allocted_res"].ToString();
            }
        }
    }
}
