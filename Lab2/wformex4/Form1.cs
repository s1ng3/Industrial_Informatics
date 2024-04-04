using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace wformex4
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cars");
            listBox1.Items.Add("Cities");
            listBox1.Items.Add("Dogs");
            listBox1.Items.Add("Cats");
            listBox1.Items.Add("Artists");
            listBox1.Items.Add("Engineers");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayImage();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopSound();
            DisplayImage();
        }

        private void DisplayImage()
        {
            string selectedListItem = listBox1.SelectedItem?.ToString();

            if (selectedListItem != null)
            {
                string imageName = $"{selectedListItem}.jpg";
                string imagePath = $@"D:\Industrial Informatics\Lab2\wformex4\bin\Debug\{imageName}";

                try
                {
                    Image originalImage = Image.FromFile(imagePath);
                    int newWidth = 660;
                    int newHeight = 500;
                    Image resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight));
                    this.BackgroundImage = resizedImage;
                    originalImage.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
                
                if (selectedListItem.Equals("Artists"))
                {
                    PlaySound("D:\\Industrial Informatics\\Lab2\\wformex4\\bin\\Debug\\singers.wav");
                }
                else if (selectedListItem.Equals("Dogs"))
                {
                    PlaySound("D:\\Industrial Informatics\\Lab2\\wformex4\\bin\\Debug\\dogs.wav");
                }
                else if (selectedListItem.Equals("Cats"))
                {
                    PlaySound("D:\\Industrial Informatics\\Lab2\\wformex4\\bin\\Debug\\cats.wav");
                }
                else if (selectedListItem.Equals("Cities"))
                {
                    PlaySound("D:\\Industrial Informatics\\Lab2\\wformex4\\bin\\Debug\\cities.wav");
                }
                else if (selectedListItem.Equals("Cars"))
                {
                    PlaySound("D:\\Industrial Informatics\\Lab2\\wformex4\\bin\\Debug\\cars.wav");
                }
                else if (selectedListItem.Equals("Engineers"))
                {
                    PlaySound("D:\\Industrial Informatics\\Lab2\\wformex4\\bin\\Debug\\engineers.wav");
                }
            }
        }

        private void PlaySound(string soundPath)
        {
            try
            {
                soundPlayer.SoundLocation = soundPath;
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            StopSound(); // Stop the sound when clicking on tabPage2
            this.BackgroundImage = null;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DisplayMessage("Radio button 1 selected");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DisplayMessage("Radio button 2 selected");
            }
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StopSound();
            this.BackgroundImage = null;
        }

        private void StopSound()
        {
            try
            {
                soundPlayer.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error stopping sound: {ex.Message}");
            }
        }
    }
}
