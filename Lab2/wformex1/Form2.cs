using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace wformex1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Label label_New = new Label();
            label_New.Location = new Point(260,160);
            label_New.Text = ("Hello " + Form1.true_user);
            
            this.Controls.Add(label_New);
            
        }
    }
}