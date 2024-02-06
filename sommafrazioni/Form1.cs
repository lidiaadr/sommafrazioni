using Frazioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sommafrazioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox1.Text);

            Fraction f1 = Fraction.Parse(textBox1.Text);
            textBox1.Text = f1.ToString();
        }

        private void pulisci_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void somma_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            Fraction f2 = f1.Somma(f1);
            textBox1.Text = f1.ToString();

            label1.Text = f2.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
