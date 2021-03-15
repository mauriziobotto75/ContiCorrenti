using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgettoCittadini
{
    public partial class Principale : Form
    {
        public Principale()
        {
            InitializeComponent();
        }

        private void btnVisualizzaCittadini_Click(object sender, EventArgs e)
        {
            VisualizzaCittadini visCittadini = new VisualizzaCittadini();
            visCittadini.ShowDialog();
  
        }

        private void btnInserisciCittadini_Click(object sender, EventArgs e)
        {
            InserisciCittadini insCittadini = new InserisciCittadini();
            insCittadini.ShowDialog();
  
        }

        

        private void btnNavigazione_Click_1(object sender, EventArgs e)
        {
            Navigazione Navigazione = new Navigazione();
            Navigazione.ShowDialog();
  
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Navigazione Navigazione = new Navigazione();
            Navigazione.ShowDialog();
  
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            InserisciCittadini InserisciCittadini = new InserisciCittadini();
            InserisciCittadini.ShowDialog();
  
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Navigazione Navigazione = new Navigazione();
            Navigazione.ShowDialog();
  
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creare un file di testo","Promemoria");

            XmlWriteMode file = new XmlWriteMode();
          
 
   
             
 
        }

        

         
    }
}