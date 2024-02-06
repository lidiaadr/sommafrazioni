namespace sommafrazioni
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aggiungi = new System.Windows.Forms.Button();
            this.pulisci = new System.Windows.Forms.Button();
            this.somma = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(295, 84);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(84, 28);
            this.aggiungi.TabIndex = 1;
            this.aggiungi.Text = "aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.button1_Click);
            // 
            // pulisci
            // 
            this.pulisci.Location = new System.Drawing.Point(295, 135);
            this.pulisci.Name = "pulisci";
            this.pulisci.Size = new System.Drawing.Size(84, 33);
            this.pulisci.TabIndex = 2;
            this.pulisci.Text = "pulisci";
            this.pulisci.UseVisualStyleBackColor = true;
            this.pulisci.Click += new System.EventHandler(this.pulisci_Click);
            // 
            // somma
            // 
            this.somma.Location = new System.Drawing.Point(295, 199);
            this.somma.Name = "somma";
            this.somma.Size = new System.Drawing.Size(84, 29);
            this.somma.TabIndex = 3;
            this.somma.Text = "somma";
            this.somma.UseVisualStyleBackColor = true;
            this.somma.Click += new System.EventHandler(this.somma_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(115, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.somma);
            this.Controls.Add(this.pulisci);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Button pulisci;
        private System.Windows.Forms.Button somma;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

