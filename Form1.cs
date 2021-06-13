using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        delegate void delegado(int valor);
        public Form1()
        {
            InitializeComponent();
        }     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                Thread H1 = new Thread(new ThreadStart(pro1));
                H1.Start();
            }
            else if (checkBox2.Checked == true)
            {
                Thread H2 = new Thread(new ThreadStart(pro2));
                H2.Start();
            }            
        }
        public void pro1()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            for(int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    delegado md = new delegado(mosPares);
                    this.Invoke(md, new object[] { i });
                    Thread.Sleep(200);
                }
            }
        }
        public void mosPares(int num)
        {
            label2.Text = label2.Text+num.ToString()+"\n";
        }
        public void pro2()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    delegado md = new delegado(impares);
                    this.Invoke(md, new object[] { i });
                    Thread.Sleep(200);
                }
            }
        }
        public void impares(int num)
        {
            label3.Text = label3.Text+ num.ToString()+"\n";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
