
namespace WindowsFormsApp1
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
            this.btn_clickme = new System.Windows.Forms.Button();
            this.lb_clikeme = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_cpassword = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_cpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clickme
            // 
            this.btn_clickme.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clickme.Location = new System.Drawing.Point(522, 406);
            this.btn_clickme.Name = "btn_clickme";
            this.btn_clickme.Size = new System.Drawing.Size(156, 50);
            this.btn_clickme.TabIndex = 0;
            this.btn_clickme.Text = "Sign Up";
            this.btn_clickme.UseVisualStyleBackColor = true;
            this.btn_clickme.Click += new System.EventHandler(this.btn_clickme_Click);
            // 
            // lb_clikeme
            // 
            this.lb_clikeme.AutoSize = true;
            this.lb_clikeme.Location = new System.Drawing.Point(591, 346);
            this.lb_clikeme.Name = "lb_clikeme";
            this.lb_clikeme.Size = new System.Drawing.Size(0, 13);
            this.lb_clikeme.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.Black;
            this.lb_name.Location = new System.Drawing.Point(429, 221);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(65, 25);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Name";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.ForeColor = System.Drawing.Color.Black;
            this.lb_email.Location = new System.Drawing.Point(429, 262);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(63, 25);
            this.lb_email.TabIndex = 3;
            this.lb_email.Text = "Email";
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Location = new System.Drawing.Point(639, 221);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(129, 13);
            this.tb_name.TabIndex = 4;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(639, 262);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(129, 20);
            this.tb_email.TabIndex = 5;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.Color.Black;
            this.lb_password.Location = new System.Drawing.Point(429, 299);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(98, 25);
            this.lb_password.TabIndex = 6;
            this.lb_password.Text = "password";
            // 
            // lb_cpassword
            // 
            this.lb_cpassword.AutoSize = true;
            this.lb_cpassword.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpassword.ForeColor = System.Drawing.Color.Black;
            this.lb_cpassword.Location = new System.Drawing.Point(429, 336);
            this.lb_cpassword.Name = "lb_cpassword";
            this.lb_cpassword.Size = new System.Drawing.Size(181, 25);
            this.lb_cpassword.TabIndex = 7;
            this.lb_cpassword.Text = "confirm password";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(639, 299);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(129, 20);
            this.tb_password.TabIndex = 8;
            // 
            // tb_cpassword
            // 
            this.tb_cpassword.Location = new System.Drawing.Point(639, 336);
            this.tb_cpassword.Name = "tb_cpassword";
            this.tb_cpassword.Size = new System.Drawing.Size(129, 20);
            this.tb_cpassword.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1134, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Login In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME TO ONLINE COURSE PLATFORM";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "SIGN UP ";
            this.label2.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_cpassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_cpassword);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_clikeme);
            this.Controls.Add(this.btn_clickme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clickme;
        private System.Windows.Forms.Label lb_clikeme;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_cpassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_cpassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

