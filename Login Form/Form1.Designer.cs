namespace Login_Form
{
    partial class Form1
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
            this.txtusr = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btclr = new System.Windows.Forms.Button();
            this.btsignup = new System.Windows.Forms.Button();
            this.timerlogin = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.btclose.ForeColor = System.Drawing.Color.Red;
            this.btclose.Location = new System.Drawing.Point(291, 4);
            this.btclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(66, 30);
            this.btclose.TabIndex = 0;
            this.btclose.Text = "X";
            this.btclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login to Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password :";
            // 
            // txtusr
            // 
            this.txtusr.Location = new System.Drawing.Point(146, 59);
            this.txtusr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusr.Name = "txtusr";
            this.txtusr.Size = new System.Drawing.Size(201, 22);
            this.txtusr.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(146, 89);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(201, 22);
            this.txtpass.TabIndex = 5;
            // 
            // btlogin
            // 
            this.btlogin.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btlogin.Location = new System.Drawing.Point(256, 121);
            this.btlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(92, 37);
            this.btlogin.TabIndex = 6;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btclr
            // 
            this.btclr.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btclr.Location = new System.Drawing.Point(19, 121);
            this.btclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btclr.Name = "btclr";
            this.btclr.Size = new System.Drawing.Size(84, 37);
            this.btclr.TabIndex = 7;
            this.btclr.Text = "Clear";
            this.btclr.UseVisualStyleBackColor = true;
            this.btclr.Click += new System.EventHandler(this.btclr_Click);
            // 
            // btsignup
            // 
            this.btsignup.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold);
            this.btsignup.Location = new System.Drawing.Point(146, 121);
            this.btsignup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsignup.Name = "btsignup";
            this.btsignup.Size = new System.Drawing.Size(92, 37);
            this.btsignup.TabIndex = 8;
            this.btsignup.Text = "Sign Up";
            this.btsignup.UseVisualStyleBackColor = true;
            this.btsignup.Click += new System.EventHandler(this.btsignup_Click);
            // 
            // timerlogin
            // 
            this.timerlogin.Enabled = true;
            this.timerlogin.Interval = 400;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsignup);
            this.Controls.Add(this.btclr);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusr;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btclr;
        private System.Windows.Forms.Button btsignup;
        private System.Windows.Forms.Timer timerlogin;
        private System.Windows.Forms.Label label4;
    }
}

