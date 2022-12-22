using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generation_Management_System
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void btnNewLogin_Click(object sender, EventArgs e)
        {
            Login_Data logd = new Login_Data();
            logd.Show();
            this.Hide();
        }

        private void btnGenerSystem_Click(object sender, EventArgs e)
        {
            Gender gen = new Gender();
            gen.Show();
            this.Hide();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            People peo = new People();
            peo.Show();
            this.Hide();
        }

        private void btnLiteracyRate_Click(object sender, EventArgs e)
        {
            LiteracyRate lr = new LiteracyRate();
            lr.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.Show();
            this.Hide();
        }

        private void btnBirthRate_Click(object sender, EventArgs e)
        {
            BirthRate br = new BirthRate();
            br.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fi = new Form1();
            fi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FamilyPlanning fp = new FamilyPlanning();
            fp.Show();
            this.Hide();
        }

        private void btnDeathRate_Click(object sender, EventArgs e)
        {
            DeathRate dr = new DeathRate();
            dr.Show();
            this.Hide();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            Resources rs = new Resources();
            rs.Show();
            this.Hide();
        }

        private void btnResourMan_Click(object sender, EventArgs e)
        {
            ResourcesManagement rm = new ResourcesManagement();
            rm.Show();
            this.Hide();
        }
    }
}
