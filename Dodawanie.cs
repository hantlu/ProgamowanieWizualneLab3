using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgamowanieWizualneLab3
{
    public partial class Dodawanie : Form
    {
        public delegate void DanePrzekazaneHandler(string imie, string nazwisko, int wiek, string stanowisko);
        public event DanePrzekazaneHandler DanePrzekazane;
        public Dodawanie()
        {
            InitializeComponent();
        }

        private void anulowanie_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void wpisywanie_imienia_TextChanged(object sender, EventArgs e)
        {
            string name = wpisywanie_imienia.Text;
        }

        private void zatwierdzanie_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(wpisywanie_imienia.Text) || string.IsNullOrEmpty(wpisywanie_nazwiska.Text) || string.IsNullOrEmpty(wpisywanie_wieku.Text) || string.IsNullOrEmpty(wpisywanie_stanowiska.Text))
            {
                MessageBox.Show("Prosze wypelnic wszystkie pola!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            if (!int.TryParse(wpisywanie_wieku.Text, out int wiek))
            {
                MessageBox.Show("Wiek musi być liczbą!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DanePrzekazane?.Invoke(wpisywanie_imienia.Text, wpisywanie_nazwiska.Text, wiek, wpisywanie_stanowiska.Text);

            this.Close();
        }
    }
}