using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Vyhledavac3000 {
    public partial class FormList : Form {
        public FormList() {
            InitializeComponent();
            StartingProcedure(); // Spustí počáteční proceduru při inicializaci formuláře
        }

        private readonly string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Vyhledavac3000", "Identcis.csv"); // Cesta k datovému souboru
        private List<(string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string)> identcisDataList = new(); // Seznam pro uchování dat z CSV souboru
        
        private string filePath = "";
        private enum SearchBy { // Enum pro určení typu vyhledávání
            USUAL,
            ALL
        }
        private SearchBy currentSearchBy; // Aktuální typ vyhledávání

        private void StartingProcedure() {
            // Nastaví výšku DataGridView, zobrazí informace o poslední úpravě souboru, nastaví výchozí hodnotu ComboBoxu, načte soubor a zapíše data do tabulky
            DataGridView.Height = MinimumSize.Height - (Height - TableLPContainer.Height) - DataGridView.Location.Y;
            LbFileInfo.Text = $"Naposledy upraveno - {File.GetLastWriteTime(dataPath)}";
            CbSearchBy.SelectedIndex = 0;
            CbSearchBy_SelectedIndexChanged(CbSearchBy, new EventArgs());
            LoadFile(dataPath);
            DataGridView.Font = new Font("Calibri", 10);
            WriteToTable(identcisDataList);
        }

        private void LoadFile(string path) {
            try {
                // Načte data z CSV souboru a přidá je do seznamu
                using (StreamReader sr = new(path, Encoding.UTF8)) {
                    // Přeskočí hlavičku
                    string line = sr.ReadLine();
                    while ((line = sr.ReadLine()) != null) {
                        string[] parts = line.Split(';');
                        identcisDataList.Add((
                            parts[0],
                            parts[1],
                            parts[2],
                            parts[3],
                            parts[4],
                            parts[5],
                            parts[6],
                            parts[7],
                            parts[8],
                            parts[9],
                            parts[10],
                            parts[11],
                            parts[12],
                            parts[13],
                            parts[14],
                            parts[15],
                            parts[16]
                        ));
                    }
                }
            }
            catch (Exception e) {
                // Soubor není v požadovaném formátu
                MessageBox.Show("Zvolený soubor není v požadovaném formátu Identcis.csv. Program se ukončí.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        private void WriteToTable(List<(string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string)> dataList) {
            // Zapíše data do DataGridView
            DataGridView.Rows.Clear();
            foreach (var item in dataList) {
                DataGridView.Rows.Add(
                    item.Item1,
                    item.Item2,
                    item.Item3,
                    item.Item4,
                    item.Item5,
                    item.Item6,
                    item.Item7,
                    item.Item8,
                    item.Item9,
                    item.Item10,
                    item.Item11,
                    item.Item12,
                    item.Item13,
                    item.Item14,
                    item.Item15,
                    item.Item16,
                    item.Item17);
            }
        }

        private void CbSearchBy_SelectedIndexChanged(object sender, EventArgs e) {
            // Nastaví typ vyhledávání podle vybrané hodnoty v ComboBoxu
            ComboBox cb = sender as ComboBox;
            currentSearchBy = (SearchBy)cb.SelectedIndex;
        }

        private void FormList_FormClosing(object sender, FormClosingEventArgs e) {
            // Ukončí aplikaci při zavření formuláře
            Environment.Exit(0);
        }

        private void BtSearch_Click(object sender, EventArgs e) {
            // Po dobu načítání dat zobrazuje na tlačítku text načítání
            string originalButtonText = BtSearch.Text;
            BtSearch.Text = "Načítání...";
            BtSearch.Enabled = false;

            // Filtruje data podle vstupu a zobrazí je v DataGridView
            string filter = SearchTextBox.Text;
            List<(string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string)> filteredDataList = new();

            // Indexy sloupců, které se prohledávají v různých možnostech hledání
            int[][] columnsToSearch = {
                [5, 6, 7, 9], // Název/kód obce, Název/kód katas. území
                [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16] // Vše
            };

            // Filtruje data podle vstupu
            foreach (var line in identcisDataList) {
                if (RbIs.Checked) {
                    foreach(int columnIndex in columnsToSearch[(int)currentSearchBy])
                        if (((ITuple)line)[columnIndex].ToString().ToLower() == filter.ToLower()) {
                            filteredDataList.Add(line);
                            break;
                        }
                } else {
                    foreach (int columnIndex in columnsToSearch[(int)currentSearchBy])
                        if (((ITuple)line)[columnIndex].ToString().ToLower().Contains(filter.ToLower())) {
                            filteredDataList.Add(line);
                            break;
                        }
                }
            }
            WriteToTable(filteredDataList);

            // Nastaví šířku sloupců tak, aby odpovídala obsahu
            foreach (DataGridViewColumn column in DataGridView.Columns) {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            BtSearch.Text = originalButtonText;
            BtSearch.Enabled = true;
        }
    }
}
