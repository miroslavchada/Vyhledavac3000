using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Ude;

namespace Vyhledavac3000 {
    public partial class FormStart : Form {
        public FormStart() {
            InitializeComponent();

            // Nastaví cestu k souboru
            fileWithPath = @$"{Path.GetDirectoryName(Application.ExecutablePath)}\Identcis.csv".Replace('\\', '/');
            // Povolí spuštní, pokud soubor již existuje
            EnableStartIfFileExists(fileWithPath);
        }

        private readonly string fileNameWithExt = "Identcis.csv";
        private string fileWithPath = "";

        private void BtSvnLoad_Click(object sender, EventArgs e) {
            string svnUrl = "svn://subversion.gepro/kokes/Kokes.700/TABLES.EXP";
            string? outputDir = fileWithPath;

            // Stáhne soubor ze SVN a vrátí kód výsledku
            int svnDownloadEndCode = DownloadSvnFile(svnUrl, fileNameWithExt, outputDir);
            string svnDownloadInfo = "";
            switch (svnDownloadEndCode) {
                case 0:
                    svnDownloadInfo = "Identcis.csv úspìšnì naèten ze SVN";
                    break;
                case 1:
                    svnDownloadInfo = "Identcis.csv se nepodaøilo naèíst ze SVN";
                    break;
                case 9:
                    svnDownloadInfo = "TIMEOUT: Identcis.csv se nepodaøilo naèíst ze SVN";
                    break;
            }

            // Pøevede soubor na UTF-8 a zkontroluje, zda existuje
            ConvertFileToUtf8();
            EnableStartIfFileExists(fileWithPath);
            LbFileName.Text = svnDownloadInfo;
        }

        private void BtFileSelect_Click(object sender, EventArgs e) {
            if (OpenFileDialogCsv.ShowDialog() != DialogResult.OK)
                return;

            // Kopíruje vybraný soubor do cílové složky
            FileInfo Sourcefile = new FileInfo(OpenFileDialogCsv.FileName);
            Sourcefile.CopyTo(@$"{Application.ExecutablePath}\..\{fileNameWithExt}", true);
            LbFileName.Text = $"Zvolen soubor {OpenFileDialogCsv.SafeFileName}";

            // Pøevede soubor na UTF-8 a zkontroluje, zda existuje
            ConvertFileToUtf8();
            EnableStartIfFileExists(OpenFileDialogCsv.SafeFileName);
        }

        private int DownloadSvnFile(string svnUrl, string fileName, string outputDir) {
            // Definuje parametry pro proces
            LbFileName.Text = "Probíhá stahování...";
            ProcessStartInfo processSvnSI = new ProcessStartInfo();
            processSvnSI.FileName = "cmd.exe";
            processSvnSI.Arguments = $"/c svn export --force {svnUrl}/{fileName} {outputDir ?? "./"}"; // /c øíká cmd, aby provedl pøíkaz a poté se ukonèil
            Debug.WriteLine(processSvnSI.Arguments);
            processSvnSI.RedirectStandardOutput = true;
            processSvnSI.RedirectStandardError = true;
            processSvnSI.UseShellExecute = false; // Vyžadováno pro pøesmìrování výstupu
            processSvnSI.CreateNoWindow = true; // Nevytváøí okno

            try {
                using (Process processSvn = new()) {
                    processSvn.StartInfo = processSvnSI;

                    processSvn.OutputDataReceived += (sender, args) => Debug.WriteLine(args.Data);
                    processSvn.ErrorDataReceived += (sender, args) => Debug.WriteLine("Chyba procesu: " + args.Data);

                    processSvn.Start();
                    processSvn.BeginOutputReadLine();
                    processSvn.BeginErrorReadLine();

                    // Volitelnì: poèká, až proces dokonèí
                    bool finished = processSvn.WaitForExit(10000);
                    if (!finished) {
                        processSvn.Kill();
                        return 9;
                    }
                }
            } catch (Exception e) {
                Debug.WriteLine(e);
                return 1;
            }
            BtStart.Focus();
            return 0;
        }

        private void EnableStartIfFileExists(string fileName) {
            // Povolí tlaèítko Start, pokud soubor existuje
            BtStart.Enabled = File.Exists(fileName);
            BtStart.Focus();
        }

        private void ConvertFileToUtf8() {
            DateTime lastWriteTime = File.GetLastWriteTimeUtc(fileWithPath);
            string srcEncoding = "Windows-1250";
            string dstEncoding = "UTF-8";

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Pøeète veškerý text ze vstupního souboru
            string[] content = File.ReadAllLines(fileWithPath, Encoding.GetEncoding(srcEncoding));

            // Zapíše obsah do výstupního souboru pomocí FileStream a kódování UTF-8 bez BOM
            using (StreamWriter sw = new(new FileStream(fileWithPath, FileMode.Create), new UTF8Encoding(false))) {
                foreach (var line in content) {
                    sw.WriteLine(line);
                }
            }
            // Sets new files last write time to same as the original file
            File.SetLastWriteTimeUtc(fileWithPath, lastWriteTime);
        }

        private void BtStart_Click(object sender, EventArgs e) {
            BtStart.Text = "Naèítání...";
            BtStart.Enabled = false;

            // Inicializuje nový formuláø a skryje se
            FormList formList = new();
            formList.Show();
            Hide();
            // (Tento formuláø se vypíná pozdìji - zároveò se zavøením okna s vyhledáváním)
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e) {
            // Ukonèí aplikaci pøi zavøení formuláøe
            Environment.Exit(0);
        }
    }
}
