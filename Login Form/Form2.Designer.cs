namespace Login_Form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtusrname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.rdbtmale = new System.Windows.Forms.RadioButton();
            this.rdbtfmale = new System.Windows.Forms.RadioButton();
            this.rdbtother = new System.Windows.Forms.RadioButton();
            this.btsignup = new System.Windows.Forms.Button();
            this.btclr = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.lbshow = new System.Windows.Forms.Label();
            this.pbarsignup = new System.Windows.Forms.ProgressBar();
            this.dataGridtesting = new System.Windows.Forms.DataGridView();
            this.timersignup = new System.Windows.Forms.Timer(this.components);
            this.timerpbar = new System.Windows.Forms.Timer(this.components);
            this.btfnameclr = new System.Windows.Forms.Button();
            this.btusrclr = new System.Windows.Forms.Button();
            this.btpassclr = new System.Windows.Forms.Button();
            this.btlnameclr = new System.Windows.Forms.Button();
            this.lbidno = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btfindclr = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btsrch = new System.Windows.Forms.Button();
            this.btsrchclose = new System.Windows.Forms.Button();
            this.pnlhead = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btconclr = new System.Windows.Forms.Button();
            this.pnlsrch = new System.Windows.Forms.Panel();
            this.btgridclose = new System.Windows.Forms.Button();
            this.pnlgrid = new System.Windows.Forms.Panel();
            this.lbcontcatcher = new System.Windows.Forms.Label();
            this.pbargrid = new System.Windows.Forms.ProgressBar();
            this.btdlt = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtesting)).BeginInit();
            this.pnlhead.SuspendLayout();
            this.pnlsrch.SuspendLayout();
            this.pnlgrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.btclose.ForeColor = System.Drawing.Color.Red;
            this.btclose.Location = new System.Drawing.Point(584, 2);
            this.btclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(66, 30);
            this.btclose.TabIndex = 1;
            this.btclose.Text = "X";
            this.btclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign Up To Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.label4.Location = new System.Drawing.Point(336, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "User Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.label6.Location = new System.Drawing.Point(20, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.label7.Location = new System.Drawing.Point(20, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.label8.Location = new System.Drawing.Point(14, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Contact No. :";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(163, 52);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(172, 22);
            this.txtfname.TabIndex = 11;
            this.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtusrname
            // 
            this.txtusrname.Location = new System.Drawing.Point(163, 116);
            this.txtusrname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusrname.Name = "txtusrname";
            this.txtusrname.Size = new System.Drawing.Size(172, 22);
            this.txtusrname.TabIndex = 12;
            this.txtusrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(163, 146);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(172, 22);
            this.txtpass.TabIndex = 13;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(163, 178);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(172, 22);
            this.txtcontact.TabIndex = 14;
            this.txtcontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            this.txtcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(468, 50);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(172, 22);
            this.txtlname.TabIndex = 15;
            this.txtlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdbtmale
            // 
            this.rdbtmale.AutoSize = true;
            this.rdbtmale.Font = new System.Drawing.Font("Cambria", 9.25F);
            this.rdbtmale.Location = new System.Drawing.Point(163, 85);
            this.rdbtmale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtmale.Name = "rdbtmale";
            this.rdbtmale.Size = new System.Drawing.Size(63, 23);
            this.rdbtmale.TabIndex = 16;
            this.rdbtmale.TabStop = true;
            this.rdbtmale.Text = "Male";
            this.rdbtmale.UseVisualStyleBackColor = true;
            // 
            // rdbtfmale
            // 
            this.rdbtfmale.AutoSize = true;
            this.rdbtfmale.Font = new System.Drawing.Font("Cambria", 9.25F);
            this.rdbtfmale.Location = new System.Drawing.Point(235, 85);
            this.rdbtfmale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtfmale.Name = "rdbtfmale";
            this.rdbtfmale.Size = new System.Drawing.Size(79, 23);
            this.rdbtfmale.TabIndex = 17;
            this.rdbtfmale.TabStop = true;
            this.rdbtfmale.Text = "Female";
            this.rdbtfmale.UseVisualStyleBackColor = true;
            // 
            // rdbtother
            // 
            this.rdbtother.AutoSize = true;
            this.rdbtother.Font = new System.Drawing.Font("Cambria", 9.25F);
            this.rdbtother.Location = new System.Drawing.Point(322, 85);
            this.rdbtother.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtother.Name = "rdbtother";
            this.rdbtother.Size = new System.Drawing.Size(76, 23);
            this.rdbtother.TabIndex = 18;
            this.rdbtother.TabStop = true;
            this.rdbtother.Text = "Others";
            this.rdbtother.UseVisualStyleBackColor = true;
            // 
            // btsignup
            // 
            this.btsignup.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btsignup.Location = new System.Drawing.Point(453, 165);
            this.btsignup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsignup.Name = "btsignup";
            this.btsignup.Size = new System.Drawing.Size(92, 37);
            this.btsignup.TabIndex = 21;
            this.btsignup.Text = "Sign Up";
            this.btsignup.UseVisualStyleBackColor = true;
            this.btsignup.Click += new System.EventHandler(this.btsignup_Click);
            // 
            // btclr
            // 
            this.btclr.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btclr.Location = new System.Drawing.Point(354, 166);
            this.btclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btclr.Name = "btclr";
            this.btclr.Size = new System.Drawing.Size(92, 37);
            this.btclr.TabIndex = 20;
            this.btclr.Text = "Clear";
            this.btclr.UseVisualStyleBackColor = true;
            this.btclr.Click += new System.EventHandler(this.btclr_Click);
            // 
            // btlogin
            // 
            this.btlogin.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btlogin.Location = new System.Drawing.Point(553, 165);
            this.btlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(92, 37);
            this.btlogin.TabIndex = 19;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // lbshow
            // 
            this.lbshow.AutoSize = true;
            this.lbshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbshow.ForeColor = System.Drawing.Color.Blue;
            this.lbshow.Location = new System.Drawing.Point(11, 213);
            this.lbshow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbshow.Name = "lbshow";
            this.lbshow.Size = new System.Drawing.Size(433, 22);
            this.lbshow.TabIndex = 22;
            this.lbshow.Text = ">>>  Click Here To Get the Detail From Data Base !!!";
            this.lbshow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbshow.Click += new System.EventHandler(this.lbshow_Click);
            // 
            // pbarsignup
            // 
            this.pbarsignup.Location = new System.Drawing.Point(453, 218);
            this.pbarsignup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbarsignup.Name = "pbarsignup";
            this.pbarsignup.Size = new System.Drawing.Size(192, 12);
            this.pbarsignup.TabIndex = 23;
            this.pbarsignup.Visible = false;
            // 
            // dataGridtesting
            // 
            this.dataGridtesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtesting.Location = new System.Drawing.Point(12, 11);
            this.dataGridtesting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridtesting.Name = "dataGridtesting";
            this.dataGridtesting.RowHeadersWidth = 62;
            this.dataGridtesting.Size = new System.Drawing.Size(627, 265);
            this.dataGridtesting.TabIndex = 24;
            // 
            // timersignup
            // 
            this.timersignup.Enabled = true;
            this.timersignup.Interval = 400;
            // 
            // timerpbar
            // 
            this.timerpbar.Tick += new System.EventHandler(this.timerpbar_Tick);
            // 
            // btfnameclr
            // 
            this.btfnameclr.BackColor = System.Drawing.Color.Red;
            this.btfnameclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfnameclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfnameclr.ForeColor = System.Drawing.Color.Yellow;
            this.btfnameclr.Location = new System.Drawing.Point(164, 52);
            this.btfnameclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btfnameclr.Name = "btfnameclr";
            this.btfnameclr.Size = new System.Drawing.Size(37, 23);
            this.btfnameclr.TabIndex = 27;
            this.btfnameclr.Text = "CLR";
            this.btfnameclr.UseVisualStyleBackColor = false;
            this.btfnameclr.Click += new System.EventHandler(this.btsaprtclr);
            // 
            // btusrclr
            // 
            this.btusrclr.BackColor = System.Drawing.Color.Red;
            this.btusrclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btusrclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btusrclr.ForeColor = System.Drawing.Color.Yellow;
            this.btusrclr.Location = new System.Drawing.Point(163, 117);
            this.btusrclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btusrclr.Name = "btusrclr";
            this.btusrclr.Size = new System.Drawing.Size(37, 23);
            this.btusrclr.TabIndex = 28;
            this.btusrclr.Text = "CLR";
            this.btusrclr.UseVisualStyleBackColor = false;
            this.btusrclr.Click += new System.EventHandler(this.btsaprtclr);
            // 
            // btpassclr
            // 
            this.btpassclr.BackColor = System.Drawing.Color.Red;
            this.btpassclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpassclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpassclr.ForeColor = System.Drawing.Color.Yellow;
            this.btpassclr.Location = new System.Drawing.Point(164, 146);
            this.btpassclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btpassclr.Name = "btpassclr";
            this.btpassclr.Size = new System.Drawing.Size(37, 23);
            this.btpassclr.TabIndex = 29;
            this.btpassclr.Text = "CLR";
            this.btpassclr.UseVisualStyleBackColor = false;
            this.btpassclr.Click += new System.EventHandler(this.btsaprtclr);
            // 
            // btlnameclr
            // 
            this.btlnameclr.BackColor = System.Drawing.Color.Red;
            this.btlnameclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlnameclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlnameclr.ForeColor = System.Drawing.Color.Yellow;
            this.btlnameclr.Location = new System.Drawing.Point(468, 51);
            this.btlnameclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlnameclr.Name = "btlnameclr";
            this.btlnameclr.Size = new System.Drawing.Size(37, 23);
            this.btlnameclr.TabIndex = 31;
            this.btlnameclr.Text = "CLR";
            this.btlnameclr.UseVisualStyleBackColor = false;
            this.btlnameclr.Click += new System.EventHandler(this.btsaprtclr);
            // 
            // lbidno
            // 
            this.lbidno.AutoSize = true;
            this.lbidno.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.lbidno.Location = new System.Drawing.Point(87, 18);
            this.lbidno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbidno.Name = "lbidno";
            this.lbidno.Size = new System.Drawing.Size(24, 25);
            this.lbidno.TabIndex = 32;
            this.lbidno.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(160, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 22);
            this.label11.TabIndex = 33;
            this.label11.Text = "[ Auto Generated ]";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btfindclr
            // 
            this.btfindclr.BackColor = System.Drawing.Color.Red;
            this.btfindclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfindclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfindclr.ForeColor = System.Drawing.Color.Yellow;
            this.btfindclr.Location = new System.Drawing.Point(288, 14);
            this.btfindclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btfindclr.Name = "btfindclr";
            this.btfindclr.Size = new System.Drawing.Size(37, 23);
            this.btfindclr.TabIndex = 37;
            this.btfindclr.Text = "CLR";
            this.btfindclr.UseVisualStyleBackColor = false;
            this.btfindclr.Click += new System.EventHandler(this.btsaprtclr);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(288, 14);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(210, 22);
            this.txtfind.TabIndex = 35;
            this.txtfind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtfind.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            this.txtfind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12.25F);
            this.label13.Location = new System.Drawing.Point(12, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 25);
            this.label13.TabIndex = 34;
            this.label13.Text = "Write Contact No. To Find :";
            // 
            // btsrch
            // 
            this.btsrch.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.btsrch.Location = new System.Drawing.Point(507, 10);
            this.btsrch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsrch.Name = "btsrch";
            this.btsrch.Size = new System.Drawing.Size(100, 30);
            this.btsrch.TabIndex = 38;
            this.btsrch.Text = "Search";
            this.btsrch.UseVisualStyleBackColor = true;
            this.btsrch.Click += new System.EventHandler(this.btsrch_Click);
            // 
            // btsrchclose
            // 
            this.btsrchclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btsrchclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsrchclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.btsrchclose.ForeColor = System.Drawing.Color.Red;
            this.btsrchclose.Location = new System.Drawing.Point(619, 16);
            this.btsrchclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsrchclose.Name = "btsrchclose";
            this.btsrchclose.Size = new System.Drawing.Size(21, 20);
            this.btsrchclose.TabIndex = 39;
            this.btsrchclose.Text = "X";
            this.btsrchclose.UseVisualStyleBackColor = false;
            this.btsrchclose.Click += new System.EventHandler(this.btsrchclose_Click);
            // 
            // pnlhead
            // 
            this.pnlhead.Controls.Add(this.label9);
            this.pnlhead.Controls.Add(this.btconclr);
            this.pnlhead.Controls.Add(this.btpassclr);
            this.pnlhead.Controls.Add(this.pnlsrch);
            this.pnlhead.Controls.Add(this.btfnameclr);
            this.pnlhead.Controls.Add(this.btusrclr);
            this.pnlhead.Controls.Add(this.label3);
            this.pnlhead.Controls.Add(this.label2);
            this.pnlhead.Controls.Add(this.label4);
            this.pnlhead.Controls.Add(this.label5);
            this.pnlhead.Controls.Add(this.label6);
            this.pnlhead.Controls.Add(this.label7);
            this.pnlhead.Controls.Add(this.label11);
            this.pnlhead.Controls.Add(this.label8);
            this.pnlhead.Controls.Add(this.lbidno);
            this.pnlhead.Controls.Add(this.txtfname);
            this.pnlhead.Controls.Add(this.btlnameclr);
            this.pnlhead.Controls.Add(this.txtusrname);
            this.pnlhead.Controls.Add(this.txtpass);
            this.pnlhead.Controls.Add(this.txtcontact);
            this.pnlhead.Controls.Add(this.txtlname);
            this.pnlhead.Controls.Add(this.rdbtmale);
            this.pnlhead.Controls.Add(this.rdbtfmale);
            this.pnlhead.Controls.Add(this.pbarsignup);
            this.pnlhead.Controls.Add(this.rdbtother);
            this.pnlhead.Controls.Add(this.lbshow);
            this.pnlhead.Controls.Add(this.btlogin);
            this.pnlhead.Controls.Add(this.btsignup);
            this.pnlhead.Controls.Add(this.btclr);
            this.pnlhead.Location = new System.Drawing.Point(-2, 44);
            this.pnlhead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlhead.Name = "pnlhead";
            this.pnlhead.Size = new System.Drawing.Size(654, 254);
            this.pnlhead.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "label9";
            // 
            // btconclr
            // 
            this.btconclr.BackColor = System.Drawing.Color.Red;
            this.btconclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconclr.ForeColor = System.Drawing.Color.Yellow;
            this.btconclr.Location = new System.Drawing.Point(164, 178);
            this.btconclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btconclr.Name = "btconclr";
            this.btconclr.Size = new System.Drawing.Size(37, 23);
            this.btconclr.TabIndex = 30;
            this.btconclr.Text = "CLR";
            this.btconclr.UseVisualStyleBackColor = false;
            this.btconclr.Click += new System.EventHandler(this.btsaprtclr);
            // 
            // pnlsrch
            // 
            this.pnlsrch.Controls.Add(this.btgridclose);
            this.pnlsrch.Controls.Add(this.btfindclr);
            this.pnlsrch.Controls.Add(this.txtfind);
            this.pnlsrch.Controls.Add(this.label13);
            this.pnlsrch.Controls.Add(this.btsrchclose);
            this.pnlsrch.Controls.Add(this.btsrch);
            this.pnlsrch.Location = new System.Drawing.Point(4, 206);
            this.pnlsrch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlsrch.Name = "pnlsrch";
            this.pnlsrch.Size = new System.Drawing.Size(654, 44);
            this.pnlsrch.TabIndex = 41;
            this.pnlsrch.Visible = false;
            // 
            // btgridclose
            // 
            this.btgridclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btgridclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btgridclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.btgridclose.ForeColor = System.Drawing.Color.Red;
            this.btgridclose.Location = new System.Drawing.Point(619, 16);
            this.btgridclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btgridclose.Name = "btgridclose";
            this.btgridclose.Size = new System.Drawing.Size(21, 20);
            this.btgridclose.TabIndex = 40;
            this.btgridclose.Text = "X";
            this.btgridclose.UseVisualStyleBackColor = false;
            this.btgridclose.Visible = false;
            this.btgridclose.Click += new System.EventHandler(this.btgridclose_Click);
            // 
            // pnlgrid
            // 
            this.pnlgrid.Controls.Add(this.lbcontcatcher);
            this.pnlgrid.Controls.Add(this.pbargrid);
            this.pnlgrid.Controls.Add(this.btdlt);
            this.pnlgrid.Controls.Add(this.btupdate);
            this.pnlgrid.Controls.Add(this.btsave);
            this.pnlgrid.Controls.Add(this.dataGridtesting);
            this.pnlgrid.Location = new System.Drawing.Point(0, 293);
            this.pnlgrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlgrid.Name = "pnlgrid";
            this.pnlgrid.Size = new System.Drawing.Size(653, 322);
            this.pnlgrid.TabIndex = 42;
            this.pnlgrid.Visible = false;
            // 
            // lbcontcatcher
            // 
            this.lbcontcatcher.AutoSize = true;
            this.lbcontcatcher.Location = new System.Drawing.Point(451, 258);
            this.lbcontcatcher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcontcatcher.Name = "lbcontcatcher";
            this.lbcontcatcher.Size = new System.Drawing.Size(169, 16);
            this.lbcontcatcher.TabIndex = 30;
            this.lbcontcatcher.Text = "I get the Contact from Table";
            this.lbcontcatcher.Visible = false;
            // 
            // pbargrid
            // 
            this.pbargrid.Location = new System.Drawing.Point(11, 295);
            this.pbargrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbargrid.Name = "pbargrid";
            this.pbargrid.Size = new System.Drawing.Size(328, 12);
            this.pbargrid.TabIndex = 29;
            this.pbargrid.Visible = false;
            // 
            // btdlt
            // 
            this.btdlt.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btdlt.Location = new System.Drawing.Point(347, 282);
            this.btdlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btdlt.Name = "btdlt";
            this.btdlt.Size = new System.Drawing.Size(92, 37);
            this.btdlt.TabIndex = 28;
            this.btdlt.Text = "Delete";
            this.btdlt.UseVisualStyleBackColor = true;
            // 
            // btupdate
            // 
            this.btupdate.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btupdate.Location = new System.Drawing.Point(446, 282);
            this.btupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(92, 37);
            this.btupdate.TabIndex = 27;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            // 
            // btsave
            // 
            this.btsave.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btsave.Location = new System.Drawing.Point(547, 282);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(92, 37);
            this.btsave.TabIndex = 26;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 615);
            this.Controls.Add(this.pnlgrid);
            this.Controls.Add(this.pnlhead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtesting)).EndInit();
            this.pnlhead.ResumeLayout(false);
            this.pnlhead.PerformLayout();
            this.pnlsrch.ResumeLayout(false);
            this.pnlsrch.PerformLayout();
            this.pnlgrid.ResumeLayout(false);
            this.pnlgrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtusrname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.RadioButton rdbtmale;
        private System.Windows.Forms.RadioButton rdbtfmale;
        private System.Windows.Forms.RadioButton rdbtother;
        private System.Windows.Forms.Button btsignup;
        private System.Windows.Forms.Button btclr;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Label lbshow;
        private System.Windows.Forms.ProgressBar pbarsignup;
        private System.Windows.Forms.DataGridView dataGridtesting;
        private System.Windows.Forms.Timer timersignup;
        private System.Windows.Forms.Timer timerpbar;
        private System.Windows.Forms.Button btfnameclr;
        private System.Windows.Forms.Button btusrclr;
        private System.Windows.Forms.Button btpassclr;
        private System.Windows.Forms.Button btlnameclr;
        private System.Windows.Forms.Label lbidno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btfindclr;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btsrch;
        private System.Windows.Forms.Button btsrchclose;
        private System.Windows.Forms.Panel pnlhead;
        private System.Windows.Forms.Panel pnlsrch;
        private System.Windows.Forms.Button btgridclose;
        private System.Windows.Forms.Panel pnlgrid;
        private System.Windows.Forms.Button btdlt;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.ProgressBar pbargrid;
        private System.Windows.Forms.Label lbcontcatcher;
        private System.Windows.Forms.Button btconclr;
        private System.Windows.Forms.Label label9;
    }
}