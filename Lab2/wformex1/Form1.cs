using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wformex1
{
    public partial class Form1 : Form
    {
        public static string true_user;
        public string true_password;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("logindata.txt");
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;
            
            true_user = streamReader.ReadLine();
            true_password = streamReader.ReadLine();
                
            try
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(user_password) && username==true_user && user_password==true_password)
                {
                    Form2 secondForm = new Form2();
                    secondForm.Show();
                    this.Hide();
                }
                else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(user_password) || username!=true_user || user_password!=true_password)
                {
                    MessageBox.Show("Username or password is incorrect or empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }
        
        
    }
}