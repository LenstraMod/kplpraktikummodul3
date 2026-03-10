using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
            }

            if (textBox1.Text == "") {
                MessageBox.Show("Masukkan angka yang valid");
            }

            //Celcius
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0) {
                textBox2.Text = textBox1.Text;
            }

            //Celcius to Reamur
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3) {
                int r = int.Parse(textBox1.Text) / 5 * 4;
                textBox2.Text = r.ToString();
            }

            //Celcius to Fahrenheit
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1) {
                double f = double.Parse(textBox1.Text) * (9 / 5) + 32;
                textBox2.Text = f.ToString();
            }

            //Celcius to Kelvin
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2) {
                int k = int.Parse(textBox1.Text) + 273;
                textBox2.Text = k.ToString();
            }

            //Reamur
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 3)
            {
                textBox2.Text = textBox1.Text;
            }

            //Reamur to Celcius
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                int rc = int.Parse(textBox1.Text) / 4 * 5;
                textBox2.Text = rc.ToString();
            }

            //Reamur to fahrenheit
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
            {
                double rf = double.Parse(textBox1.Text) / 9 + 32;
                textBox2.Text = rf.ToString();
            }

            //Reamur to kelvin
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
            {
                int rc = int.Parse(textBox1.Text) / 4 * 5;
                int rk = rc + 273;
                textBox2.Text = rk.ToString();
            }

            //Fahrenheit
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1) {
                textBox2.Text = textBox1.Text;
            }

            //Fahrenheit to celcius
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0) {
                double fc = (double.Parse(textBox1.Text) - 32) * (0.55556);
                textBox2.Text = fc.ToString();
            }

            //Fahrenheit to Reamur
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
            {
                double fr = (double.Parse(textBox1.Text) - 32) * (0.444444);
                textBox2.Text = fr.ToString();
            }

            //Fahrenheit to Kelvin
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2) {
                double fc = (double.Parse(textBox1.Text) - 32) * (5 / 9);
                double fk = fc + 273;
                textBox2.Text = fk.ToString();
            }

            //Kelvin
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                textBox2.Text = textBox1.Text;
            }

            //Kevin to Celcius
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                double kc = double.Parse(textBox1.Text) - 273;
                textBox2.Text =kc.ToString();
            }

            //Kelvin to Reamur
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
            {
                double kc = double.Parse(textBox1.Text) - 273;
                double cr = kc / 5 * 4;
                textBox2.Text = cr.ToString();
            }

            //Kevin to Fahrenheit
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                double kc = double.Parse(textBox1.Text) - 273;
                double kf = kc * (9 / 5) + 32;
                textBox2.Text = kf.ToString();
            }
        }
    }
}
