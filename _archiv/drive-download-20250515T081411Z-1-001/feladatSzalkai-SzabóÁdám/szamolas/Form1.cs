using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace szamolas
{
    public partial class Form1 : Form
    {

        SortedSet<int> egyesSet = new SortedSet<int>();
        SortedSet<int> kettesSet = new SortedSet<int>();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            button2.Enabled = false;

            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(7);
            comboBox1.Items.Add(8);
            comboBox1.Items.Add(9);
            comboBox1.Items.Add(10);
            comboBox1.Items.Add(11);
            comboBox1.Items.Add(12);
            comboBox1.Items.Add(13);
            comboBox1.Items.Add(14);
            comboBox1.Items.Add(15);
            comboBox1.Items.Add(16);
            comboBox1.Items.Add(17);
            comboBox1.Items.Add(18);
            comboBox1.Items.Add(19);
            comboBox1.Items.Add(20);

            comboBox2.Items.Add(5);
            comboBox2.Items.Add(6);
            comboBox2.Items.Add(7);
            comboBox2.Items.Add(8);
            comboBox2.Items.Add(9);
            comboBox2.Items.Add(10);
            comboBox2.Items.Add(11);
            comboBox2.Items.Add(12);
            comboBox2.Items.Add(13);
            comboBox2.Items.Add(14);
            comboBox2.Items.Add(15);
            comboBox2.Items.Add(16);
            comboBox2.Items.Add(17);
            comboBox2.Items.Add(18);
            comboBox2.Items.Add(19);
            comboBox2.Items.Add(20);

            this.Controls.Add(comboBox1);
            this.Controls.Add(comboBox2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;


            String egy = comboBox1.Text;
            String ketto = comboBox2.Text;

            int egySzam = Convert.ToInt32(egy);
            int kettoSzam = Convert.ToInt32(ketto);


            Random rnd = new Random();

            for (int j = 0; j < egySzam; j++)
            {
                egyesSet.Add(rnd.Next(1, 101));
            }

            for (int jj = 0; jj < kettoSzam; jj++)
            {
                kettesSet.Add(rnd.Next(1, 101));
            }

            textBox1.Text = String.Join(Environment.NewLine, egyesSet);
            textBox2.Text = String.Join(Environment.NewLine, kettesSet);


            List<int> egyesLista = egyesSet.ToList();
            List<int> kettesLista = kettesSet.ToList();

    
            int osszeg = 0;
            for (int i = 0; i < egyesLista.Count; i++)
            {
                osszeg = osszeg + egyesLista[i];
            }  
            label5.Text += osszeg;

            int osszeg2 = 0;
            for (int i = 0; i < kettesLista.Count; i++)
            {
                osszeg2 = osszeg2 + kettesLista[i];
            }  
            label6.Text += osszeg2;

            label3.Text += (osszeg / egyesLista.Count).ToString();
            label4.Text += (osszeg2 / kettesLista.Count).ToString();


            int min;
            min = egyesLista[0];
            for (int i = 1; i < egyesLista.Count; i++)
            {
                if (egyesLista[i] < min)
                {
                    min = egyesLista[i];
                }
                    
            }
            label7.Text += min.ToString();

            int max;
            max = kettesLista[0];
            for (int i = 0; i < kettesLista.Count; i++)
            {
                if (kettesLista[i] > max)
                {
                    max = kettesLista[i];
                }
            }
            label8.Text += max.ToString();



            List<int> metszet = new List<int>();
            
            for (int i = 0; i < egyesLista.Count; i++)
            {
                for (int j = 0; j < kettesLista.Count; j++)
                {
                    if (egyesLista[i] == kettesLista[j])
                    {
                        bool jojo = true;
                        for (int k = 0; k < metszet.Count; k++)
                        {
                            if (egyesLista[i] == metszet[k])
                            {jojo = false;
                            }
                        }
                        if (jojo == true)
                        {
                                metszet.Add(egyesLista[i]);
                        }     
                    }
                }
            }
      
            metszet.Sort();
            textBox3.Text = String.Join(Environment.NewLine, metszet);



            List<int> unio = new List<int>();

            for (int i = 0; i < egyesLista.Count; i++)
            {
                bool jojo = true;
                for (int j = 0; j < unio.Count; j++)
                {
                    if (egyesLista[i] == unio[j] || kettesLista[i] == unio[j])
                    {
                       jojo = false;
                    }

                }
                if (jojo == true)
                {
                    unio.Add(egyesLista[i]);
                    unio.Add(kettesLista[i]);
                }
            }

            unio.Sort();
            textBox4.Text = String.Join(Environment.NewLine, unio);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
