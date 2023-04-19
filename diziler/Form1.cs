using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace diziler
{
    public partial class Form1 : Form
    {
        ArrayList ortalamalar = new ArrayList();
        Random  number = new Random();
        int diziBoyutu = 40; //Varsayılan dizi boyutu 40 olucak.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 0; i < diziBoyutu; i++)
            {
                ortalamalar.Add(Convert.ToDouble(number.NextDouble()*100));
                listBox1.Items.Add(ortalamalar[i]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bölüme dizinin eleman sayısını yazınız");
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            ortalamalar.Clear();
            listBox1.Items.Clear();
            for (int i = 0; i < diziBoyutu; i++)
            {
                ortalamalar.Add(Convert.ToDouble(number.NextDouble() * 100));
                listBox1.Items.Add(ortalamalar[i]);
            }
        }

    

        private void btnAraSayilar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach(double num in ortalamalar)
            {
                if(num >= 70 && num < 85)
                {
                    listBox2.Items.Add(num);
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            foreach (double num in ortalamalar)
            {
                if (num < 50)
                {
                    listBox3.Items.Add(num);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            ortalamalar.Sort();

            foreach (double num in ortalamalar)
            {
                listBox4.Items.Add(num);
            }
            


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            diziBoyutu = value;
        }
    }
}
