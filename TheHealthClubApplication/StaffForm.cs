using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHealthClubApplication
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();

        }

        //Close Staff Form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Display information about the staff member when their picture is clicked (Gwen Stacy)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainInfolabel.Text = "Gwen Stacy is the head of our Yoga division. She has over 10 years of experience in teaching yoga and meditation. She personally oversees that everyone gets the proper care and attention they need, wether it be longtime Yoga veterans or newcomers alike. With this course, she aims to help students achieve their fitness goals through a combination of physical exercise and mental well-being.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        //Display information about the staff member when their picture is clicked (Ben Urich)
        private void BenUrichpictureBox_Click(object sender, EventArgs e)
        {
            MainInfolabel.Text = "Ben Urich is our lead Sensei in the arts of Karate. Ben takes the art and sport of Karate very seriously and is devoted to making sure that his students train and maintain a constant regimine of physical fitness to not only ensure his students improve in karate but to also make sure his students are physically fit and healthy.";
        }
        //Display information about the staff member when their picture is clicked (Claire Jackson)
        private void ClaireJacksonpictureBox_Click(object sender, EventArgs e)
        {
            MainInfolabel.Text = "Claire Jackson is our certified personal trainer. She specializes in creating customized workout plans for each client, ensuring they reach their fitness goals efficiently and safely. Claire is passionate about helping people of all fitness levels achieve their potential through dedication and personalized attention. With this course, Claire hopes to oversee that her clients develop a natural drive and passion to overcome any obstacle that her clients face.";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
