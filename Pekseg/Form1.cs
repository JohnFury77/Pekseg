using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pekseg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownPekaru_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonHozzaadPekaru_Click(object sender, EventArgs e)
        {
            int pekaruAr = Convert.ToInt32(numericUpDownPekaru.Value);
            bool laktoz = checkBoxLaktoz.Checked;
            
            Pekaru pekaru = new Pekaru(textBoxPekaru.Text, pekaruAr, laktoz);
            listBoxPekaru.Items.Add(pekaru);
        }

        private void listBoxPekaru_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pekaru p = (Pekaru)listBoxPekaru.SelectedItem;
            string tboxba = p.Nev;
            textBoxPekaru.Text = tboxba;
            int tboxbaar = p.Ar;
            numericUpDownPekaru.Value = tboxbaar;
            bool checkboxba = p.Laktozmentes;
            if (checkboxba)
            {
                checkBoxLaktoz.Checked = true;
            }
            else
            {
                checkBoxLaktoz.Checked = false;
            }
        }

        private void tabPageAdatok_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPekaru_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHozzaadPekseg_Click(object sender, EventArgs e)
        {
            Pekseg p = new Pekseg(textBoxPekseg.Text, DateTime.Now);
            listBoxPekseg.Items.Add(p);
            listBoxStat.Items.Add(p);
        }

        private void buttonHozzaadPekaru2_Click(object sender, EventArgs e)
        {
            if (listBoxPekaru.SelectedIndex != -1 && listBoxPekseg.SelectedIndex != -1)
            {
                Pekaru p = (Pekaru)listBoxPekaru.SelectedItem;
                Pekseg pekseg = (Pekseg)listBoxPekseg.SelectedItem;
                pekseg.SetTermekek(p);
            }

        }

        private void listBoxPekseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPekaru2.Items.Clear();
            Pekseg p = (Pekseg)listBoxPekseg.SelectedItem;
            foreach (var item in p.GetTermekek())
            {
                listBoxPekaru2.Items.Add(item);
            }
        }

        private void listBoxStat_SelectedIndexChanged(object sender, EventArgs e)
        {

            Pekseg p = (Pekseg)listBoxStat.SelectedItem;
            string pnev = p.Nev;
            peksegNeve.Text = pnev;


            DateTime palapitas = p.Alapitva;
            alapitva.Text = ($"Alapítva: {Convert.ToString(palapitas)}");


            double parukszama = p.GetTermekek().Count;
            pekaru.Text = ($"Pékáruk: {Convert.ToString(parukszama)}");


            double atlagar = 0;
            double sum = 0;
            foreach (var item in p.GetTermekek())
            {
                sum += item.Ar;
            }
            atlagar = sum / p.GetTermekek().Count;
            avgAr.Text=($"Átlagos ár: {Convert.ToString(atlagar)} Ft");


            Pekaru paru=p.GetTermekek()[0];
            foreach (var item in p.GetTermekek())
            {
                if (paru.Ar>item.Ar)
                {
                    paru = item;
                }
            }
            minTermek.Text = ($"Legolcsóbb termék: {paru.ToString()}");


            paru = p.GetTermekek()[0];
            foreach (var item in p.GetTermekek())
            {
                if (paru.Ar < item.Ar)
                {
                    paru = item;
                }
            }
            maxTermek.Text = ($"Legdrágább termék: {paru.ToString()}");


            int laktozdb = 0;
            foreach (var item in p.GetTermekek())
            {
                if (item.Laktozmentes)
                {
                    laktozdb++;
                }
            }
            double szazalek= (laktozdb / parukszama) *100;
            laktozlabel.Text = ($"Laktózmentes termékek száma: {Convert.ToString(laktozdb)}  Db, az összes termék {szazalek}%-a");




        }

        private void tabControlStatisztikak_Click(object sender, EventArgs e)
        {

        }
    }
}
