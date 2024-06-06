using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Быки_и_коровы
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "ValLera-MIX-Untitled.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 newForm = new Form2();
            newForm.Show();
            player.controls.stop();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            player.controls.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            player.controls.stop();
            Hide();
        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
