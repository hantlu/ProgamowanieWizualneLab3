using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgamowanieWizualneLab3
{
    public partial class Pracownicy : Form
    {
        
        public Pracownicy()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("imie", "Imię");
            dataGridView1.Columns.Add("nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("wiek", "Wiek");
            dataGridView1.Columns.Add("stanow", "Stanowisko");
        }


        private void dodawanie_Click(object sender, EventArgs e)
        {
            Dodawanie dodawanie = new Dodawanie();
            //dodawanie.
            dodawanie.Show();
        }

        private void Form2_DanePrzekazane(string imie, string nazwisko, int wiek, string stanowisko)
        {
            // Dodajemy nowy wiersz do DataGridView
            dataGridView1.Rows.Add(imie, nazwisko, wiek.ToString(), stanowisko);
        }
    }
}
