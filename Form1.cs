using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int textBox1_TextChanged = int.Parse(Console.ReadLine());
            int textBox2_TextChanged = int.Parse(Console.ReadLine());
            int textBox3_TextChanged = int.Parse(Console.ReadLine());
            int razhodKeremidi = 9;

            double S = (textBox1_TextChanged + textBox2_TextChanged) * textBox3_TextChanged / 2;
            double brojKeremidi = S * razhodKeremidi;

            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                Console.WriteLine(S);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                Console.WriteLine(brojKeremidi);
        }
    }
}
