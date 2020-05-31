using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rozpoznawanieLiczb
{
    public partial class Form1 : Form
    {
        public CheckBox[] boxesList = new CheckBox[100];
        public int[] boxesChecked = new int[100];
        public String numberCode;
        public int szukanaLiczba=-1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            #region tworzenie plikow txt
            if (!File.Exists("0.txt"))
            {
                using (StreamWriter sw = File.CreateText("0.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("1.txt"))
            {
                using (StreamWriter sw = File.CreateText("1.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("2.txt"))
            {
                using (StreamWriter sw = File.CreateText("2.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("3.txt"))
            {
                using (StreamWriter sw = File.CreateText("3.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("4.txt"))
            {
                using (StreamWriter sw = File.CreateText("4.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("5.txt"))
            {
                using (StreamWriter sw = File.CreateText("5.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("6.txt"))
            {
                using (StreamWriter sw = File.CreateText("6.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("7.txt"))
            {
                using (StreamWriter sw = File.CreateText("7.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("8.txt"))
            {
                using (StreamWriter sw = File.CreateText("8.txt"))
                {
                    sw.WriteLine("");
                }
            }
            if (!File.Exists("9.txt"))
            {
                using (StreamWriter sw = File.CreateText("9.txt"))
                {
                    sw.WriteLine("");
                }
            }
            #endregion

            int x = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(CheckBox))
                {
                    boxesList[x] = (ctrl as CheckBox);
                    x++;
                }
            }
            Array.Reverse(boxesList);
            //MessageBox.Show(boxesList[0].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            while (x < 100)
            {
                if (boxesList[x].Checked)
                {
                    boxesChecked[x] = 1;
                }
                else
                {
                    boxesChecked[x] = 0;
                }
                x++;
            }

            numberCode="";
            int z = 0;
            while(z<100)
            {
                numberCode += boxesChecked[z];
                z++;
            }            
            button1.Hide();
            groupBox1.Show();

            //przeszukiwanie plikow txt
            szukanaLiczba = -1;
            foreach (var line in File.ReadLines("0.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 0;
                    break;
                }
            }
            foreach (var line in File.ReadLines("1.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 1;
                    break;
                }
            }
            foreach (var line in File.ReadLines("2.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 2;
                    break;
                }
            }
            foreach (var line in File.ReadLines("3.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 3;
                    break;
                }
            }
            foreach (var line in File.ReadLines("4.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 4;
                    break;
                }
            }
            foreach (var line in File.ReadLines("5.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 5;
                    break;
                }
            }
            foreach (var line in File.ReadLines("6.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 6;
                    break;
                }
            }
            foreach (var line in File.ReadLines("7.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 7;
                    break;
                }
            }
            foreach (var line in File.ReadLines("8.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 8;
                    break;
                }
            }
            foreach (var line in File.ReadLines("9.txt"))
            {
                if (line == numberCode)
                {
                    szukanaLiczba = 9;
                    break;
                }
            }

            if (szukanaLiczba == -1)
            {
                label1.Text = "Niestety, nie wiem jaką liczbę"+Environment.NewLine+"masz na myśli.";
                radioButton1.Hide();
                radioButton2.Checked = true;
                radioButton2.Text = "Moja liczba to:";
            }
            else
            {
                radioButton1.Show();
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton2.Text = "Nie, moja liczba to:";
                label1.Text = "Czy Twoja liczba to " + szukanaLiczba.ToString() + "?";
            }
            //MessageBox.Show(numberCode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                switch(numericUpDown1.Value)
                {
                    case 0:
                        File.AppendAllText("0.txt",numberCode + Environment.NewLine);
                        break;
                    case 1:
                        File.AppendAllText("1.txt", numberCode + Environment.NewLine);
                        break;
                    case 2:
                        File.AppendAllText("2.txt", numberCode + Environment.NewLine);
                        break;
                    case 3:
                        File.AppendAllText("3.txt", numberCode + Environment.NewLine);
                        break;
                    case 4:
                        File.AppendAllText("4.txt", numberCode + Environment.NewLine);
                        break;
                    case 5:
                        File.AppendAllText("5.txt", numberCode + Environment.NewLine);
                        break;
                    case 6:
                        File.AppendAllText("6.txt", numberCode + Environment.NewLine);
                        break;
                    case 7:
                        File.AppendAllText("7.txt", numberCode + Environment.NewLine);
                        break;
                    case 8:
                        File.AppendAllText("8.txt", numberCode + Environment.NewLine);
                        break;
                    case 9:
                        File.AppendAllText("9.txt", numberCode + Environment.NewLine);
                        break;
                }
            }
            button1.Show();
            groupBox1.Hide();
        }
    }
}
