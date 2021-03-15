using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgettoCittadini
   

{
    public partial class Navigazione : Form
    {
        public Navigazione()
        {
            InitializeComponent();
        }

        private void Navigazione_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tbCittadinoDataSet.tbCittadino' table. You can move, or remove it, as needed.
            this.tbCittadinoTableAdapter.Fill(this.tbCittadinoDataSet.tbCittadino);
           
          

        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            tbCittadinoBindingSource.MoveFirst();
            
     
 
 
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            tbCittadinoBindingSource.MoveLast();
  
        }

        private void btnSuccessivo_Click(object sender, EventArgs e)
        {
            tbCittadinoBindingSource.MoveNext();
            if (tbCittadinoBindingSource.Position > tbCittadinoBindingSource.Count)
                tbCittadinoBindingSource.MovePrevious();
  
        }

        private void btnPrecedente_Click(object sender, EventArgs e)
        {
            tbCittadinoBindingSource.MovePrevious();
            if (tbCittadinoBindingSource.Position == -1)
                tbCittadinoBindingSource.MoveNext();
  
        }

        private void cmdAggiungi_Click(object sender, EventArgs e)
        {
            
             
       
           this.tbCittadinoBindingSource.EndEdit();
        //    this.tbCittadinoBindingSource.Add(tbCittadinoDataSet.tbCittadino);     
 
        //    MessageBox.Show("Update successful");

 

   
  
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

           btnPrimo_Click(sender, e);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            btnPrecedente_Click(sender, e);
 
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            btnSuccessivo_Click(sender, e);
 
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            btnUltimo_Click(sender, e);
 
 
        }

       
    }
}