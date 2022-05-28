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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /* idcall method is for auto Generated ID */
        private void idcall()
        {
            db.com.CommandText = "select max(id)+1 from testing";
            db.dr = db.com.ExecuteReader();
            if (db.dr.Read())
            {
                lbidno.Text = db.dr[0].ToString();
                if (lbidno.Text == null)
                    lbidno.Text = "1";
            }
            db.dr.Close();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }


        string Gen, Name;
        int i;
        private void btsignup_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "" || txtlname.Text == "" ||(rdbtmale.Checked == false && rdbtfmale.Checked == false && rdbtother.Checked == false)|| txtusrname.Text == "" || txtpass.Text == "" || txtcontact.Text == "")
            {
                    MessageBox.Show("Some details are left, check carefully");
            }
            else if (txtcontact.TextLength != 10)
            {
                MessageBox.Show("Please provide your correct contact...");
            }
            else
            {
                timerpbar.Enabled = true;

                if (rdbtmale.Checked == true)
                    Gen = rdbtmale.Text;
                else if (rdbtfmale.Checked == true)
                    Gen = rdbtfmale.Text;
                else
                    Gen = rdbtother.Text;
                Name = txtfname.Text + " " + txtlname.Text;
                if (pbarsignup.Value == i)
                {
                    db.com.CommandText = "insert into testing values('" + lbidno.Text + "','" + Name + "','" + Gen + "','" + txtusrname.Text + "','" + txtpass.Text + "','" + txtcontact.Text + "')";
                    if (db.com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data Saved Successfully..");
                        pbarsignup.Value = 0;
                        this.Close();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    else
                        MessageBox.Show("Error while saving your Sign Up details..\n Try again...");
                    //db.con.Close();
                }
            }
        }

        private void timerpbar_Tick(object sender, EventArgs e)
        {
            pbarsignup.Visible = true;
            do
            {
                pbarsignup.Value += 2;
            }
            while (pbarsignup.Value <= 98);
            i = pbarsignup.Value;
            timerpbar.Stop();
        }

        private void btclr_Click(object sender, EventArgs e)
        {
            txtfname.Text = txtlname.Text = txtusrname.Text = txtpass.Text = txtcontact.Text = "";
            rdbtfmale.Checked = false; rdbtmale.Checked = false; rdbtother.Checked = false;
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btsaprtclr(object sender, EventArgs e)
        {
            string  name;
            //Button bt = (Button)sender;
            Button bt = sender as Button;
            name = bt.Name;
            if (name == btfnameclr.Name)
                txtfname.Text = null;
            else if (name == btlnameclr.Name)
                txtlname.Text = null;
            else if (name == btusrclr.Name)
                txtusrname.Text = null;
            else if (name == btpassclr.Name)
                txtpass.Text = null;
            else if (name == btconclr.Name)
                txtcontact.Text = null;
            else if (name == btfindclr.Name)
                txtfind.Text = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            idcall();
            this.Height = 300;
            this.Width = 653;
        }

        private void lbshow_Click(object sender, EventArgs e)
        {
            pnlsrch.Visible = true;
            lbshow.Visible = false;
        }

        private void btsrchclose_Click(object sender, EventArgs e)
        {
            this.Height = 300;
            lbshow.Visible = true;
            pnlsrch.Visible = false;
        }

        private void btsrch_Click(object sender, EventArgs e)
        {
            btsrchclose.Visible = false;  //close button for search panel
            btgridclose.Visible = true;
            btgridclose.Visible = true;
            pnlgrid.Visible = true;
            this.Height = 615;

            testLoadData();
        }

        /* testLoadData method load data on data grid view */
        private void testLoadData()
        {
            //confromdata = $ -post['contactinfo'];
            //confromdata = $-StartPosition{'contactinfo' }
          
            db.com.CommandText = "select id,name,gender,username from testing where contactinfo = '"+ txtfind.Text +"' ";
            SqlDataAdapter sda = new SqlDataAdapter(db.com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridtesting.DataSource = dt;

            /*db.com.CommandText = "select contactinfo from testing ";
            SqlDataAdapter sdacont = new SqlDataAdapter(db.com);
            DataTable dtcont = new DataTable();
            sdacont.Fill(dtcont);
            dataGridtesting.DataSource=dtcont;*/
        }

        private void btgridclose_Click(object sender, EventArgs e)
        {
            pnlgrid.Visible = false;
            this.Height = 300;
            btgridclose.Visible = false;
            btsrchclose.Visible = true;
        }

        private void onlyNumber(object sender, KeyPressEventArgs e)     // <- This is keyPress Event
        {
            txtcontact.MaxLength = 10;
            txtfind.MaxLength = 10;
        }

        int nocon;
        /* Need a function here for both the text box used for entering contact */
        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            TextBox tbcon = sender as TextBox;
            if (txtcontact.Text == 0.ToString())
            {
                txtcontact.Text = null;
            }
            if (txtcontact.Focused == true)
            {
                txtcontact.Text = tbcon.Text;
                for (int i = 0; i < txtcontact.TextLength; i++)
                    check(txtcontact.Text[i], i);
            }
            if (txtfind.Focused == true)
            {
                txtfind.Text = tbcon.Text;
                for (int i = 0; i < txtfind.TextLength; i++)
                    check(txtfind.Text[i], i);
            }
        }

        private void check(char chcon, int i)
        {
            label9.Text = chcon.ToString();
            nocon = Convert.ToInt32(chcon);
            //   label9.Text = nocon.ToString();    this is for marked text box
            if (nocon >= 48 && nocon <= 57) { }
            else if (txtcontact.Focused == true)
            {
                txtcontact.Text = txtcontact.Text.Substring(0, txtcontact.Text.Length - 1);
            }
            else if (txtfind.Focused == true)
            {
                txtfind.Text = txtfind.Text.Substring(0, txtfind.Text.Length - 1);
            }
        }
    }
}
