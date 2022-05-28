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

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btclr_Click(object sender, EventArgs e)
        {
            txtpass.Text = "";
            txtusr.Text = "";
        }

        private void btsignup_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            db.com.CommandText = "select username,password from testing where username = '" + txtusr.Text + "' and password = '"+txtpass.Text+"'";
            SqlDataAdapter sda  = new SqlDataAdapter(db.com);
            DataTable dt = new DataTable();
           // sda.Fill(dt);   //returns 0,1
            if (sda.Fill(dt) == 1)
            {
                MessageBox.Show("login successfull...");
                this.Close();
                Form3 f3 = new Form3(); 
                f3.Show();
            }
            else
            {
                MessageBox.Show("sign up to proceed");
            }
            //dataGridView1.DataSource = dt;
            //this.Height = 300;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 360;
            this.Height = 165;
        }
    }
}
