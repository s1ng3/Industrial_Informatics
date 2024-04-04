using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace wformex2
{
    public partial class Form1 : Form
    {
        private void PopulateListBoxFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    
                    foreach (string line in lines)
                    {
                        listBox1.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("The specified file does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateListBoxFromFile("words.txt");
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                foreach (var item in listBox2.SelectedItems.OfType<object>().ToList())
                {
                    listBox2.Items.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing items: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}