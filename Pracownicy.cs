using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgamowanieWizualneLab3
{
    public partial class Pracownicy : Form
    {

        private int id = 0;
        public Pracownicy()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("lp", "ID");
            dataGridView1.Columns.Add("imie", "Imię");
            dataGridView1.Columns.Add("nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("wiek", "Wiek");
            dataGridView1.Columns.Add("stanow", "Stanowisko");
        }


        private void dodawanie_Click(object sender, EventArgs e)
        {
            Dodawanie dodawanie = new Dodawanie();
            dodawanie.DanePrzekazane += Form2_DanePrzekazane;
            dodawanie.Show();
        }

        private void Form2_DanePrzekazane(string imie, string nazwisko, int wiek, string stanowisko)
        {
            // Dodajemy nowy wiersz do DataGridView

            ++id;
            dataGridView1.Rows.Add(id, imie, nazwisko, wiek.ToString(), stanowisko);
            
        }

        private void usuwanie_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void zapisywanie_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savefiledialog = new SaveFileDialog())
            {
                savefiledialog.Filter = "Pliki CSV (*.csv)|*.csv";
                savefiledialog.Title = "Zapis pliku do CSV";
                savefiledialog.FileName = "pracownicy.csv";

                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = savefiledialog.FileName;
                    export(dataGridView1, filePath);
                    MessageBox.Show("Plik zostal zapisany!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void export(DataGridView datagridview, string filePath)
        {
            string csvContent = "ID, Imię, Nazwisko, Wiek, Stanowisko" + Environment.NewLine;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            File.WriteAllText(filePath, csvContent);
        }

        private void import(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik nie istnieje!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                MessageBox.Show("Plik jest pusty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //dataGridView1.Rows.Clear(); 

            for (int i = 1; i < lines.Length; i++) 
            {
                string[] values = lines[i].Split(',');

                if (values.Length == dataGridView1.Columns.Count)
                {
                    dataGridView1.Rows.Add(values);
                }
                else
                {
                    MessageBox.Show($"Błąd w linii {i + 1}: Nieprawidłowa liczba kolumn!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void odczytywanie_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Wybierz plik CSV do wczytania";
            openFileDialog.ShowDialog();

            if(openFileDialog.FileName != "")
            {
                import(openFileDialog.FileName);
            }
        }
    }
}
