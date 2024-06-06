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

    public partial class Form4 : Form
    {
        public Form2 f2 = new Form2();
        public int urf4;
        public int randI;
        public Form4()
        {
            InitializeComponent();
        }
        public string [] easyWord = new string[] { "сено", "роза", "парк", "мука", "язык", "конь", "корм", "очки" };
        public string [] normalWord = new string[] { "агрессия", "агрессор", "агератум", "аквапарк", "бергамот", "банкомат", "вакансия", "вездеход" };
        public string [] hardWord = new string[] { "абсорбироваться", "абстрагирование", "авангардистский", "авансодержатель", "авантюристичный", "авиаконструктор", "авиаметеослужба", "авиаопыливатель" };
        public void Form4_Load(object sender, EventArgs e)
        {
            if (urf4 == 1) textBox1.MaxLength = 4;
            if (urf4 == 2) textBox1.MaxLength = 8;
            if (urf4 == 3)textBox1.MaxLength = 15;
         }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
        }
        Random ran = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
             randI = ran.Next(8);
             label2.Text = "...";
             textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (urf4 == 1)
            {
                string word = easyWord[randI];
                string userWord = textBox1.Text;
                char[] wordArray = word.ToCharArray();
                char[] userWordArray = userWord.ToCharArray();
                int countBk = 0, countKr = 0;
                for (int i = 0; i < wordArray.Length; i++)
                    for (int iuser = 0; iuser < userWordArray.Length; iuser++)
                    {
                        if (userWordArray[iuser] == wordArray[i] && i != iuser) countKr++;
                        if (userWordArray[iuser] == wordArray[i] && i == iuser) countBk++;
                    }
                if (countBk!=4) label2.Text = "количество коров = " + countKr + "; количество быков = " + countBk;
                else if (countBk == 4) label2.Text = "Вы угадали!";
            }
            if (urf4 ==2)
            {
                string word = normalWord[randI];
                string userWord = textBox1.Text;
                char[] wordArray = word.ToCharArray();
                char[] userWordArray = userWord.ToCharArray();
                int countBk = 0, countKr = 0;
                for (int i = 0; i < wordArray.Length; i++)
                    for (int iuser = 0; iuser < userWordArray.Length; iuser++)
                    {
                        if (userWordArray[iuser] == wordArray[i] && i != iuser) countKr++;
                        if (userWordArray[iuser] == wordArray[i] && i == iuser) countBk++;
                    }
                if (countBk != 8) label2.Text = "количество коров = " + countKr + "; количество быков = " + countBk;
                else if (countBk == 8) label2.Text = "Вы угадали!";
            }
            if(urf4==3)
            {
                string word = hardWord[randI];
                string userWord = textBox1.Text;
                char[] wordArray = word.ToCharArray();
                char[] userWordArray = userWord.ToCharArray();
                int countBk = 0, countKr = 0;
                for (int i = 0; i < wordArray.Length; i++)
                    for (int iuser = 0; iuser < userWordArray.Length; iuser++)
                    {
                        if (userWordArray[iuser] == wordArray[i] && i != iuser) countKr++;
                        if (userWordArray[iuser] == wordArray[i] && i == iuser) countBk++;
                    }
                if (countBk != 15) label2.Text = "количество коров = " + countKr + "; количество быков = " + countBk;
                else if (countBk == 15) label2.Text = "Вы угадали!";
            }
        }
    
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                char c = e.KeyChar;
                if (e.Handled = !((c >= 'а' && c <= 'я') || c == 'ё' || c == 8 || c == 46)) MessageBox.Show("В поле можно вводить только прописные буквы кириллицы!", "Ошибка!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}