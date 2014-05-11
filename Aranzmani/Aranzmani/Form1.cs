using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aranzmani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Aranzman a1 = new Aranzman("Majorka", "Spanija", 10, 1500);
            Aranzman a2 = new Aranzman("Pariz", "Franzija", 5, 500);
            Aranzman a3 = new Aranzman("Krf", "Grcija", 12, 1000);
            Aranzman a4 = new Aranzman("Dubrovnik", "Hrvatska", 6, 1500);
            lbAranzmani.Items.Add(a1);
            lbAranzmani.Items.Add(a2);
            lbAranzmani.Items.Add(a3);
            lbAranzmani.Items.Add(a4);
        }

        private void lbAranzmani_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aranzman a = lbAranzmani.SelectedItem as Aranzman;
            try
            {
                tbMesto.Text = a.mesto;
                tbDrzava.Text = a.mesto;
                tbDenovi.Text = a.denovi.ToString();
                tbCena.Text = a.cena.ToString();
            }
            catch (NullReferenceException) { }
        }

        private void btnPrazniA_Click(object sender, EventArgs e)
        {
            if (lbAranzmani.Items.Count != 0)
            {
                lbAranzmani.Items.Clear();
                tbCena.Text=null;
                tbMesto.Text=null;
                tbDrzava.Text=null;
                tbDenovi.Text=null;
            }
            else
                MessageBox.Show("Listata e veke prazna");
        }

        private void btnBrisiA_Click(object sender, EventArgs e)
        {
            /*if (lbAranzmani.SelectedItems.Count > 0)//ako ima nesto selektirano
            {
                Aranzman a = lbAranzmani.SelectedItem as Aranzman;
                lbAranzmani.Items.Remove(a);
                tbCena.Text = null;
                tbMesto.Text = null;
                tbDrzava.Text = null;
                tbDenovi.Text = null;
            }

            else
                MessageBox.Show("Odberi eden");*/

            //proba da vrati nesto
            if (lbRezervacija.SelectedItems.Count > 0)
            {
                Rezervacija a = lbRezervacija.SelectedItem as Rezervacija;
                lbAranzmani.Items.Add(a);
                lbRezervacija.Items.Remove(a);
            }
            else
                MessageBox.Show("nema nisto");

        }

        private void btnPrazniR_Click(object sender, EventArgs e)
        {
            if (lbRezervacija.Items.Count != 0)
            {
                lbRezervacija.Items.Clear();
                calculate();
            }
            else
                MessageBox.Show("Listata e veke prazna");
        }

        int ima(Rezervacija r)
        {
            
           int suma = 0;

            foreach (Rezervacija rez in lbRezervacija.Items)
            {
               // int brojac;
                if ((rez.aranzmani.mesto.Equals(r.aranzmani.mesto)) && (rez.aranzmani.cena.Equals(r.aranzmani.cena)) && (rez.aranzmani.denovi.Equals(r.aranzmani.denovi)))
                {
                    suma += 1;
        
                }
               
            }
            return suma;
        }

        private void btnDodadiR_Click(object sender, EventArgs e)
        {
            if (lbAranzmani.SelectedItems.Count > 0)//ako e selektirano nesto
            {
                Rezervacija r = new Rezervacija();
                r.aranzmani = (Aranzman)lbAranzmani.SelectedItem;
                r.lica = (int)nLica.Value;
                r.doplata = (int)nDoplata.Value;
                if (ima(r)<3)
                {
                    lbRezervacija.Items.Add(r);
                    calculate();
                   
                }
                else
                    MessageBox.Show("Ne moze");
            }
            else
                MessageBox.Show("Selektiraj nesto");
        }

        public void calculate()
        {
            int vkupnoLica=0;
            int vkupnoCena = 0;
            foreach (Rezervacija rez in lbRezervacija.Items)
            {

                vkupnoLica += Convert.ToInt32(rez.lica);
                vkupnoCena += Convert.ToInt32(rez.aranzmani.cena);
            }
            tbVklica.Text = vkupnoLica.ToString();
            tbVkCena.Text = vkupnoCena.ToString();

        }

        private void btnDodadiA_Click(object sender, EventArgs e)
        {
            NovAranzman nov = new NovAranzman();
            if (nov.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbAranzmani.Items.Add(nov.aranzmann);
            }
        }

        private void btnNajdolg_Click(object sender, EventArgs e)
        {
            Aranzman najdolg = (Aranzman)lbAranzmani.Items[0];
            foreach (Aranzman a in lbAranzmani.Items)
            {
                if (a.denovi > najdolg.denovi)
                {
                    najdolg = a;
                }


                
            }
            MessageBox.Show(String.Format("Najdolg e {0}", najdolg));
        }

         
       
       
    }
}
