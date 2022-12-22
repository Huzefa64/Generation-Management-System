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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Interface inter = new Interface();
            if (txtEmail.Text=="huzefa23@gmail.com" && txtPassword.Text=="rana5678" && txtUsername.Text=="Huzefa23")
            {
                MessageBox.Show("Login Successfully...");
                inter.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Login Failed..");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generation_Management_SystemDataSet3.tblLogin_Admin' table. You can move, or remove it, as needed.
            this.tblLogin_AdminTableAdapter.Fill(this.generation_Management_SystemDataSet3.tblLogin_Admin);

        }
    }
}
