using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void btn_clickme_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("please Enter user name");
            }
            else if (tb_email.Text=="")
            {
                MessageBox.Show("please Enter email");
            }
            else if (tb_password.Text == "")
            {
                MessageBox.Show("please Enter password");
            }
            else if (tb_cpassword.Text == "")
            {
                MessageBox.Show("please Enter password");
            }
            else if (tb_password.Text != tb_cpassword.Text)
            {
                MessageBox.Show("password mismatch");
            }
            else
            {
                MessageBox.Show("Registration successfull : "+tb_name.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            ob.Show();
            this.Hide();
        }
    }
}
