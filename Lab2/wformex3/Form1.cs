using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wformex3
{
    public partial class Form1 : Form
    {

        public float number1;
        public float number2;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            number1 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            number2 = float.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            textBox3.Text = (number1 + number2).ToString(CultureInfo.InvariantCulture);
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            number1 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            number2 = float.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            textBox3.Text = (number1 - number2).ToString(CultureInfo.InvariantCulture);
        }

        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            number1 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            number2 = float.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            textBox3.Text = (number1 * number2).ToString(CultureInfo.InvariantCulture);
        }

        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            number1 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            number2 = float.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            textBox3.Text = (number1 / number2).ToString(CultureInfo.InvariantCulture);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

    }
}