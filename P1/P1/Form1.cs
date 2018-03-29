using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 1
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saya belajar c#");
        }
        #endregion

        #region 2
        private void button2_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(angka1TextBox.Text);
            int nilai2 = Convert.ToInt32(angka2TextBox.Text);
            int hasil = nilai1 + nilai2;

            hasilLabel.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(angka1TextBox.Text);
            int nilai2 = Convert.ToInt32(angka2TextBox.Text);
            int hasil = nilai1 - nilai2;

            hasilLabel.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(angka1TextBox.Text);
            int nilai2 = Convert.ToInt32(angka2TextBox.Text);
            int hasil = nilai1 * nilai2;

            hasilLabel.Text = hasil.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(angka1TextBox.Text);
            int nilai2 = Convert.ToInt32(angka2TextBox.Text);
            int hasil = nilai1 / nilai2;

            hasilLabel.Text = hasil.ToString();
        }
        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            int nilaiAngka = Convert.ToInt32(nilaiAngkaTextBox.Text);
            string nilaiHuruf = string.Empty;

            if (nilaiAngka >= 80)
            {
                nilaiHuruf = "A -> anda lulus";
            }
            else if (nilaiAngka >= 70)
            {
                nilaiHuruf = "B -> anda lulus";
            }
            else if (nilaiAngka >= 60)
            {
                nilaiHuruf = "c -> anda lulus";
            }
            else
            {
                nilaiHuruf = "D -> anda tidak lulus";
            }

            hasil2Label.Text = nilaiHuruf;
        }
    }
}
