using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace playfair_gui
{
    public partial class Form1 : Form
    {

        public string[] tabla = File.ReadAllLines("kulcstabla.txt");

        public Color cimke = Color.Green;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            richTextBox2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            string text = "QWERTZUIOPASDFGHJKLYXCVBNM";
            bool vege = false;
            string tmp = richTextBox1.Text + " ";


            if (tmp.Length % 3 != 0)
            {
                cimke = Color.Red;
                vege = true;
            }


            if (!vege) {  
                for (int i = 0; i < richTextBox1.Text.Length; i = i + 3)
                {
                    if (tmp[i] != ' ' && tmp[i + 1] != ' ' && tmp[i + 2] == ' ')
                    {
                        cimke = Color.Blue;
                    }
                    else
                    {
                        cimke = Color.Red;
                        vege = true;
                        break;
                    }
                }
            }


            if (!vege)
            {
                for (int i = 0; i < richTextBox1.Text.Length; i = i + 3)
                {
                    if (text.Contains(tmp[i]) && text.Contains(tmp[i + 1]))
                    {
                        cimke = Color.Green;
                    } 
                    else
                    {
                        cimke = Color.Blue;
                        vege = true;
                        break;
                    }
                }
            }


            if (!vege)
            {
                for (int i = 0; i < richTextBox1.Text.Length; i = i + 3)
                {
                    if (cimke == Color.Green && tmp[i] == tmp[i + 2])
                    {
                        cimke = Color.Magenta;
                        break;
                    }
                }
            }

            label1.ForeColor = (cimke);

            if(cimke != Color.Green)
            {
                label2.Visible = false;
                richTextBox2.Visible = false;
                richTextBox2.Text = null;
            }
            else
            {
                label2.Visible = true;
                richTextBox2.Visible = true;
                richTextBox2.Text = null;

            }

            }
        }
    }

