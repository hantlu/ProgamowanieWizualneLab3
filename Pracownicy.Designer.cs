namespace ProgamowanieWizualneLab3
{
    partial class Pracownicy
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodawanie = new System.Windows.Forms.Button();
            this.usuwanie = new System.Windows.Forms.Button();
            this.odczytywanie = new System.Windows.Forms.Button();
            this.zapisywanie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(558, 61);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(125, 68);
            this.dodawanie.TabIndex = 1;
            this.dodawanie.Text = "Dodaj";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // usuwanie
            // 
            this.usuwanie.Location = new System.Drawing.Point(562, 198);
            this.usuwanie.Name = "usuwanie";
            this.usuwanie.Size = new System.Drawing.Size(120, 79);
            this.usuwanie.TabIndex = 2;
            this.usuwanie.Text = "Usuń";
            this.usuwanie.UseVisualStyleBackColor = true;
            this.usuwanie.Click += new System.EventHandler(this.usuwanie_Click);
            // 
            // odczytywanie
            // 
            this.odczytywanie.Location = new System.Drawing.Point(428, 402);
            this.odczytywanie.Name = "odczytywanie";
            this.odczytywanie.Size = new System.Drawing.Size(182, 44);
            this.odczytywanie.TabIndex = 3;
            this.odczytywanie.Text = "Odczyt z .csv";
            this.odczytywanie.UseVisualStyleBackColor = true;
            this.odczytywanie.Click += new System.EventHandler(this.odczytywanie_Click);
            // 
            // zapisywanie
            // 
            this.zapisywanie.Location = new System.Drawing.Point(70, 402);
            this.zapisywanie.Name = "zapisywanie";
            this.zapisywanie.Size = new System.Drawing.Size(199, 44);
            this.zapisywanie.TabIndex = 4;
            this.zapisywanie.Text = "Zapis do .csv";
            this.zapisywanie.UseVisualStyleBackColor = true;
            this.zapisywanie.Click += new System.EventHandler(this.zapisywanie_Click);
            // 
            // Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 484);
            this.Controls.Add(this.zapisywanie);
            this.Controls.Add(this.odczytywanie);
            this.Controls.Add(this.usuwanie);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pracownicy";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button usuwanie;
        private System.Windows.Forms.Button odczytywanie;
        private System.Windows.Forms.Button zapisywanie;
    }
}

