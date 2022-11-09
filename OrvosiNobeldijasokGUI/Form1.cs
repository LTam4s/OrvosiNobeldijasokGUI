using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OrvosiNobeldijasokGUI
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

        private void AM_button_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.CreateText(@"uj_dijazott.txt"))
            {
            sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");

            if (string.IsNullOrEmpty(Ev_textBox.Text) || string.IsNullOrEmpty(Nev_textBox.Text) || string.IsNullOrEmpty(SzH_textBox.Text) || string.IsNullOrEmpty(Orszag_textBox.Text))
            {
                MessageBox.Show("Töltsön ki minden mezőt!", "Mentés");
            }
            else
            {
                int ev = Convert.ToInt32(Ev_textBox.Text);
                if (ev < 1989)
                {
                    MessageBox.Show("Hiba!  Az  évszám  nem  megfelelő!", "Mentés");
                }
                else
                {
                    try
                    {
                        sw.WriteLine($"{Ev_textBox.Text};{Nev_textBox.Text};{SzH_textBox.Text};{Orszag_textBox.Text}");
                        sw.Close();
                        Ev_textBox.Text = "";
                        Nev_textBox.Text = "";
                        SzH_textBox.Text = "";
                        Orszag_textBox.Text = "";

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hiba az állomány írásánál!", "Mentés");
                        throw;
                    }
                }
                }
            }
        }
    }
}
