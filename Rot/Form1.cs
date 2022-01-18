using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nwtext = "";
            int numb = Convert.ToInt32(numericUpDown1.Value);
            string text = textBox1.Text;
            text = text.ToLower();
            char[] znaky = text.ToCharArray();
            for(int i = 0; i < text.Length;i++)
            {
                if (znaky[i].ToString() == " " || znaky[i].ToString() == ".") { }
                else
                {
                    int temp = (int)znaky[i];
                    temp += numb;
                    if (temp > 122) { temp -= 26; }
                    znaky[i] = (char)temp;
                }
                    nwtext += znaky[i].ToString();
                
            }
            textBox1.Text = nwtext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nwtext = "";
            int numb = 26 - Convert.ToInt32(numericUpDown1.Value);
            string text = textBox1.Text;
            text = text.ToLower();
            char[] znaky = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (znaky[i].ToString() == " " || znaky[i].ToString() == ".") { }
                else
                {
                    int temp = (int)znaky[i];
                    temp += numb;
                    if (temp > 122) { temp -= 26; }
                    znaky[i] = (char)temp;
                }
                nwtext += znaky[i].ToString();

            }
            textBox1.Text = nwtext;
        }
    }
}
