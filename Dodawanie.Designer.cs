namespace ProgamowanieWizualneLab3
{
    partial class Dodawanie
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
            this.imielabel = new System.Windows.Forms.Label();
            this.wpisywanie_imienia = new System.Windows.Forms.TextBox();
            this.wpisywanie_nazwiska = new System.Windows.Forms.TextBox();
            this.wpisywanie_wieku = new System.Windows.Forms.TextBox();
            this.wpisywanie_stanowiska = new System.Windows.Forms.TextBox();
            this.zatwierdzanie = new System.Windows.Forms.Button();
            this.anulowanie = new System.Windows.Forms.Button();
            this.nazwiskolabel = new System.Windows.Forms.Label();
            this.wieklabel = new System.Windows.Forms.Label();
            this.stanowiskolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imielabel
            // 
            this.imielabel.AutoSize = true;
            this.imielabel.Location = new System.Drawing.Point(323, 67);
            this.imielabel.Name = "imielabel";
            this.imielabel.Size = new System.Drawing.Size(32, 16);
            this.imielabel.TabIndex = 0;
            this.imielabel.Text = "Imię";
            // 
            // wpisywanie_imienia
            // 
            this.wpisywanie_imienia.Location = new System.Drawing.Point(41, 67);
            this.wpisywanie_imienia.Name = "wpisywanie_imienia";
            this.wpisywanie_imienia.Size = new System.Drawing.Size(157, 22);
            this.wpisywanie_imienia.TabIndex = 1;
            this.wpisywanie_imienia.TextChanged += new System.EventHandler(this.wpisywanie_imienia_TextChanged);
            // 
            // wpisywanie_nazwiska
            // 
            this.wpisywanie_nazwiska.Location = new System.Drawing.Point(41, 134);
            this.wpisywanie_nazwiska.Name = "wpisywanie_nazwiska";
            this.wpisywanie_nazwiska.Size = new System.Drawing.Size(157, 22);
            this.wpisywanie_nazwiska.TabIndex = 2;
            // 
            // wpisywanie_wieku
            // 
            this.wpisywanie_wieku.Location = new System.Drawing.Point(41, 200);
            this.wpisywanie_wieku.Name = "wpisywanie_wieku";
            this.wpisywanie_wieku.Size = new System.Drawing.Size(157, 22);
            this.wpisywanie_wieku.TabIndex = 3;
            // 
            // wpisywanie_stanowiska
            // 
            this.wpisywanie_stanowiska.Location = new System.Drawing.Point(41, 262);
            this.wpisywanie_stanowiska.Name = "wpisywanie_stanowiska";
            this.wpisywanie_stanowiska.Size = new System.Drawing.Size(157, 22);
            this.wpisywanie_stanowiska.TabIndex = 4;
            // 
            // zatwierdzanie
            // 
            this.zatwierdzanie.Location = new System.Drawing.Point(41, 333);
            this.zatwierdzanie.Name = "zatwierdzanie";
            this.zatwierdzanie.Size = new System.Drawing.Size(157, 60);
            this.zatwierdzanie.TabIndex = 5;
            this.zatwierdzanie.Text = "Zatwierdź";
            this.zatwierdzanie.UseVisualStyleBackColor = true;
            this.zatwierdzanie.Click += new System.EventHandler(this.zatwierdzanie_Click);
            // 
            // anulowanie
            // 
            this.anulowanie.Location = new System.Drawing.Point(245, 333);
            this.anulowanie.Name = "anulowanie";
            this.anulowanie.Size = new System.Drawing.Size(156, 60);
            this.anulowanie.TabIndex = 6;
            this.anulowanie.Text = "Anuluj";
            this.anulowanie.UseVisualStyleBackColor = true;
            this.anulowanie.Click += new System.EventHandler(this.anulowanie_Click);
            // 
            // nazwiskolabel
            // 
            this.nazwiskolabel.AutoSize = true;
            this.nazwiskolabel.Location = new System.Drawing.Point(311, 134);
            this.nazwiskolabel.Name = "nazwiskolabel";
            this.nazwiskolabel.Size = new System.Drawing.Size(65, 16);
            this.nazwiskolabel.TabIndex = 7;
            this.nazwiskolabel.Text = "Nazwisko";
            // 
            // wieklabel
            // 
            this.wieklabel.AutoSize = true;
            this.wieklabel.Location = new System.Drawing.Point(323, 200);
            this.wieklabel.Name = "wieklabel";
            this.wieklabel.Size = new System.Drawing.Size(38, 16);
            this.wieklabel.TabIndex = 8;
            this.wieklabel.Text = "Wiek";
            // 
            // stanowiskolabel
            // 
            this.stanowiskolabel.AutoSize = true;
            this.stanowiskolabel.Location = new System.Drawing.Point(300, 268);
            this.stanowiskolabel.Name = "stanowiskolabel";
            this.stanowiskolabel.Size = new System.Drawing.Size(76, 16);
            this.stanowiskolabel.TabIndex = 9;
            this.stanowiskolabel.Text = "Stanowisko";
            // 
            // Dodawanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 418);
            this.Controls.Add(this.stanowiskolabel);
            this.Controls.Add(this.wieklabel);
            this.Controls.Add(this.nazwiskolabel);
            this.Controls.Add(this.anulowanie);
            this.Controls.Add(this.zatwierdzanie);
            this.Controls.Add(this.wpisywanie_stanowiska);
            this.Controls.Add(this.wpisywanie_wieku);
            this.Controls.Add(this.wpisywanie_nazwiska);
            this.Controls.Add(this.wpisywanie_imienia);
            this.Controls.Add(this.imielabel);
            this.Name = "Dodawanie";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imielabel;
        private System.Windows.Forms.TextBox wpisywanie_imienia;
        private System.Windows.Forms.TextBox wpisywanie_nazwiska;
        private System.Windows.Forms.TextBox wpisywanie_wieku;
        private System.Windows.Forms.TextBox wpisywanie_stanowiska;
        private System.Windows.Forms.Button zatwierdzanie;
        private System.Windows.Forms.Button anulowanie;
        private System.Windows.Forms.Label nazwiskolabel;
        private System.Windows.Forms.Label wieklabel;
        private System.Windows.Forms.Label stanowiskolabel;
    }
}