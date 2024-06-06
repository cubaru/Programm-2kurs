using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Быки_и_коровы
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        Random ran = new Random();
        
        public void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.randI = ran.Next(8);
            f4.urf4 = 1;
            f4.label1.Text = "Компьютером загаданно слово из 4 букв";
            f4.Show();
            Hide();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.randI = ran.Next(8);
            f4.urf4 = 2;
            f4.label1.Text = "Компьютером загаданно слово из 8 букв";
            f4.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.randI = ran.Next(8);
            f4.urf4 = 3;
            f4.label1.Text = "Компьютером загаданно слово из 15 букв";
            f4.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
