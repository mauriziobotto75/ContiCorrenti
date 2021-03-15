namespace ProgettoCittadini
{
    partial class Navigazione
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigazione));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tbCittadinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCittadinoDataSet = new ProgettoCittadini.tbCittadinoDataSet();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtDataNascita = new System.Windows.Forms.DateTimePicker();
            this.txtResidenza = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.cmdAggiungi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCittà = new System.Windows.Forms.TextBox();
            this.bindingCittadini = new System.Windows.Forms.BindingSource(this.components);
            this.tbCittadinoTableAdapter = new ProgettoCittadini.tbCittadinoDataSetTableAdapters.tbCittadinoTableAdapter();
            this.btnPrecedente = new System.Windows.Forms.Button();
            this.btnSuccessivo = new System.Windows.Forms.Button();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbCittadinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCittadinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCittadini)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data di Nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Residenza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Domicilio";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCittadinoBindingSource, "Nome", true));
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbCittadinoBindingSource, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(156, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(88, 20);
            this.txtNome.TabIndex = 5;
            // 
            // tbCittadinoBindingSource
            // 
            this.tbCittadinoBindingSource.DataMember = "tbCittadino";
            this.tbCittadinoBindingSource.DataSource = this.tbCittadinoDataSet;
            // 
            // tbCittadinoDataSet
            // 
            this.tbCittadinoDataSet.DataSetName = "tbCittadinoDataSet";
            this.tbCittadinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCognome
            // 
            this.txtCognome.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbCittadinoBindingSource, "Cognome", true));
            this.txtCognome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCittadinoBindingSource, "Cognome", true));
            this.txtCognome.Location = new System.Drawing.Point(157, 83);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(86, 20);
            this.txtCognome.TabIndex = 6;
            // 
            // txtDataNascita
            // 
            this.txtDataNascita.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbCittadinoBindingSource, "DataNascita", true));
            this.txtDataNascita.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCittadinoBindingSource, "DataNascita", true));
            this.txtDataNascita.Location = new System.Drawing.Point(158, 145);
            this.txtDataNascita.Name = "txtDataNascita";
            this.txtDataNascita.Size = new System.Drawing.Size(212, 20);
            this.txtDataNascita.TabIndex = 7;
            // 
            // txtResidenza
            // 
            this.txtResidenza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCittadinoBindingSource, "Residenza", true));
            this.txtResidenza.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbCittadinoBindingSource, "Residenza", true));
            this.txtResidenza.Location = new System.Drawing.Point(158, 197);
            this.txtResidenza.Name = "txtResidenza";
            this.txtResidenza.Size = new System.Drawing.Size(93, 20);
            this.txtResidenza.TabIndex = 8;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCittadinoBindingSource, "Domicilio", true));
            this.txtDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbCittadinoBindingSource, "Domicilio", true));
            this.txtDomicilio.Location = new System.Drawing.Point(156, 238);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(95, 20);
            this.txtDomicilio.TabIndex = 9;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = global::ProgettoCittadini.Properties.Resources.POINT03;
            this.btnUltimo.Location = new System.Drawing.Point(413, 299);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(95, 37);
            this.btnUltimo.TabIndex = 11;
            this.btnUltimo.Text = " ";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // cmdAggiungi
            // 
            this.cmdAggiungi.Location = new System.Drawing.Point(413, 33);
            this.cmdAggiungi.Name = "cmdAggiungi";
            this.cmdAggiungi.Size = new System.Drawing.Size(95, 46);
            this.cmdAggiungi.TabIndex = 14;
            this.cmdAggiungi.Text = "Aggiungi";
            this.cmdAggiungi.UseVisualStyleBackColor = true;
            this.cmdAggiungi.Click += new System.EventHandler(this.cmdAggiungi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Città";
            // 
            // txtCittà
            // 
            this.txtCittà.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbCittadinoBindingSource, "Citta", true));
            this.txtCittà.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbCittadinoBindingSource, "Citta", true));
            this.txtCittà.Location = new System.Drawing.Point(157, 116);
            this.txtCittà.Name = "txtCittà";
            this.txtCittà.Size = new System.Drawing.Size(89, 20);
            this.txtCittà.TabIndex = 16;
            // 
            // bindingCittadini
            // 
            this.bindingCittadini.DataMember = "tbCittadino";
            this.bindingCittadini.DataSource = this.tbCittadinoDataSet;
            // 
            // tbCittadinoTableAdapter
            // 
            this.tbCittadinoTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrecedente
            // 
            this.btnPrecedente.Image = global::ProgettoCittadini.Properties.Resources.POINT02;
            this.btnPrecedente.Location = new System.Drawing.Point(197, 299);
            this.btnPrecedente.Name = "btnPrecedente";
            this.btnPrecedente.Size = new System.Drawing.Size(95, 37);
            this.btnPrecedente.TabIndex = 13;
            this.btnPrecedente.Text = " ";
            this.btnPrecedente.UseVisualStyleBackColor = true;
            this.btnPrecedente.Click += new System.EventHandler(this.btnPrecedente_Click);
            // 
            // btnSuccessivo
            // 
            this.btnSuccessivo.Image = global::ProgettoCittadini.Properties.Resources.POINT04;
            this.btnSuccessivo.Location = new System.Drawing.Point(312, 299);
            this.btnSuccessivo.Name = "btnSuccessivo";
            this.btnSuccessivo.Size = new System.Drawing.Size(95, 37);
            this.btnSuccessivo.TabIndex = 12;
            this.btnSuccessivo.Text = " ";
            this.btnSuccessivo.UseVisualStyleBackColor = true;
            this.btnSuccessivo.Click += new System.EventHandler(this.btnSuccessivo_Click);
            // 
            // btnPrimo
            // 
            this.btnPrimo.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimo.Image")));
            this.btnPrimo.Location = new System.Drawing.Point(96, 299);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(95, 37);
            this.btnPrimo.TabIndex = 10;
            this.btnPrimo.Text = " ";
            this.btnPrimo.UseVisualStyleBackColor = true;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(576, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Primo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Precedente\r\n";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Successivo";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Ultimo";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Pulsanti_Primo.png");
            this.imageList1.Images.SetKeyName(1, "Pulsanti_Precedente.png");
            this.imageList1.Images.SetKeyName(2, "Pulsanti_Successivo.png");
            this.imageList1.Images.SetKeyName(3, "Pulsanti_Ultimo.png");
            // 
            // Navigazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 418);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCittà);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdAggiungi);
            this.Controls.Add(this.btnPrecedente);
            this.Controls.Add(this.btnSuccessivo);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtResidenza);
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Navigazione";
            this.Text = "Navigazione";
            this.Load += new System.EventHandler(this.Navigazione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCittadinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCittadinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCittadini)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.DateTimePicker txtDataNascita;
        private System.Windows.Forms.TextBox txtResidenza;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.BindingSource bindingCittadini;
        private tbCittadinoDataSet tbCittadinoDataSet;
        private System.Windows.Forms.BindingSource tbCittadinoBindingSource;
        private ProgettoCittadini.tbCittadinoDataSetTableAdapters.tbCittadinoTableAdapter tbCittadinoTableAdapter;
        private System.Windows.Forms.Button btnSuccessivo;
        private System.Windows.Forms.Button btnPrecedente;
        private System.Windows.Forms.Button cmdAggiungi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCittà;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ImageList imageList1;
    }
}