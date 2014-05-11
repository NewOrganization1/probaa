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
    
    public partial class NovAranzman : Form
    {
        public Aranzman aranzmann = new Aranzman();

        public NovAranzman()
        {
            InitializeComponent();
        }

        private void dodadi_Click(object sender, EventArgs e)
        {
            try
            {
               aranzmann.mesto=txtMesto.Text;
                aranzmann.drzava=txtDrzava.Text;
                aranzmann.denovi = (int)nDenovi.Value;
                aranzmann.cena = (int)nCena.Value;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (NullReferenceException) { }

        }

        private void otkazi_Click(object sender, EventArgs e)
        {
            DialogResult tekst = MessageBox.Show("Dali ste sigurno?", "Prasanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tekst == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtMesto_Validating(object sender, CancelEventArgs e)
        {
            if (txtMesto.Text.Length==0)
            {
                e.Cancel = true;
                errorP.SetError(txtMesto, "greska");
            }
            else
                errorP.SetError(txtMesto, null);

        }

        private void txtDrzava_Validating(object sender, CancelEventArgs e)
        {
            if (txtDrzava.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDrzava, "greska");
            }
            else
                errorProvider1.SetError(txtDrzava, null);
        }

       

       
        
    }
}
