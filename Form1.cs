using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_107_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(1, 2);
           //Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            //Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
           // Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            //Console.WriteLine("2 / 2 = " + hasilBagi);

            ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();

            a.X = 7;
            a.Y = 8;
            b.X = 5;
            b.Y = 6;

            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;

            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));
            /*Console.WriteLine("Hasil Koordinat " + jarak);
            Console.ReadLine();*/

            textBox1.Text = "1 + 2 = " + hasilTambah;
            textBox2.Text = "3 - 2 = " + hasilKurang;
            textBox3.Text = "2 x 2 = " + hasilKali;
            textBox4.Text = "2 / 2 = " + hasilBagi;
            textBox5.Text = jarak.ToString();


        }
    }
}
