using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPerpustakaan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin" && txtpassword.Text == "12345")
            {
                new Form1().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("The User Name or Password You Entered Is Incorrect, Try Again ");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }
        }
       

        private void label3_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
