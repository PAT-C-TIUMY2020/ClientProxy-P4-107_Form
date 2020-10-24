using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_107_Form
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(1, 2);
            //Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            //Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            //Console.WriteLine("2 x 2 = " + hasilKali);
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

            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2)); Console.WriteLine("Hasil Koordinat " + jarak); Console.ReadLine();
        }
    }
}
