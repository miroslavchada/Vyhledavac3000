using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Ude;

namespace Vyhledavac3000 {
    public partial class FormStart : Form {
        public FormStart() {
            InitializeComponent();

            // Nastav� cestu k souboru
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), appName, fileName);
            // Povol� spu�tn�, pokud soubor ji� existuje
            EnableStartIfFileExists(filePath);
        }

        private readonly string appName = "Vyhledavac3000";
        private readonly string fileName = "Identcis.csv";
        private string filePath = "";

        private void BtSvnLoad_Click(object sender, EventArgs e) {
            string svnUrl = "svn://subversion.gepro/kokes/Kokes.700/TABLES.EXP";
            string? outputDir = filePath;

            // Vytvo�� slo�ku v AppData, pokud neexistuje
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            // St�hne soubor ze SVN a vr�t� k�d v�sledku
            int svnDownloadEndCode = DownloadSvnFile(svnUrl, fileName, outputDir);
            string svnDownloadInfo = "";
            switch (svnDownloadEndCode) {
                case 0:
                    svnDownloadInfo = "Identcis.csv �sp�n� na�ten ze SVN";
                    break;
                case 1:
                    svnDownloadInfo = "Identcis.csv se nepoda�ilo na��st ze SVN";
                    break;
                case 9:
                    svnDownloadInfo = "TIMEOUT: Identcis.csv se nepoda�ilo na��st ze SVN";
                    break;
            }

            // Pokud soubor neexistuje, nepoda�ilo se ho st�hnout ze SVN a proces se p�eru��
            if (File.Exists(filePath)) {
                LbFileName.Text = "Identcis.csv se nepoda�ilo na��st ze SVN";
                return;
            }

            // P�evede soubor na UTF-8 a zkontroluje, zda existuje
            ConvertFileToUtf8();
            EnableStartIfFileExists(filePath);
            LbFileName.Text = svnDownloadInfo;
        }

        private void BtFileSelect_Click(object sender, EventArgs e) {
            if (OpenFileDialogCsv.ShowDialog() != DialogResult.OK)
                return;

            // Kop�ruje vybran� soubor do c�lov� slo�ky
            FileInfo Sourcefile = new FileInfo(OpenFileDialogCsv.FileName);
            // Vytvo�� slo�ku v AppData, pokud neexistuje
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            Sourcefile.CopyTo(filePath, true);
            LbFileName.Text = $"Zvolen soubor {OpenFileDialogCsv.SafeFileName}";

            // P�evede soubor na UTF-8 a zkontroluje, zda existuje
            ConvertFileToUtf8();
            EnableStartIfFileExists(OpenFileDialogCsv.SafeFileName);
        }

        private int DownloadSvnFile(string svnUrl, string fileName, string outputDir) {
            // Definuje parametry pro proces
            LbFileName.Text = "Prob�h� stahov�n�...";
            ProcessStartInfo processSvnSI = new ProcessStartInfo();
            processSvnSI.FileName = "cmd.exe";
            processSvnSI.Arguments = $"/c svn export --force {svnUrl}/{fileName} {outputDir ?? "./"}"; // /c ��k� cmd, aby provedl p��kaz a pot� se ukon�il
            Debug.WriteLine(processSvnSI.Arguments);
            processSvnSI.RedirectStandardOutput = true;
            processSvnSI.RedirectStandardError = true;
            processSvnSI.UseShellExecute = false; // Vy�adov�no pro p�esm�rov�n� v�stupu
            processSvnSI.CreateNoWindow = true; // Nevytv��� okno

            try {
                using (Process processSvn = new()) {
                    processSvn.StartInfo = processSvnSI;

                    processSvn.OutputDataReceived += (sender, args) => Debug.WriteLine(args.Data);
                    processSvn.ErrorDataReceived += (sender, args) => Debug.WriteLine("Chyba procesu: " + args.Data);

                    processSvn.Start();
                    processSvn.BeginOutputReadLine();
                    processSvn.BeginErrorReadLine();

                    // Voliteln�: po�k�, a� proces dokon��
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
            // Povol� tla��tko Start, pokud soubor existuje
            BtStart.Enabled = File.Exists(fileName);
            BtStart.Focus();
        }

        private void ConvertFileToUtf8() {
            DateTime lastWriteTime = File.GetLastWriteTimeUtc(filePath);
            string srcEncoding = "Windows-1250";
            string dstEncoding = "UTF-8";

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // P�e�te ve�ker� text ze vstupn�ho souboru
            string[] content = File.ReadAllLines(filePath, Encoding.GetEncoding(srcEncoding));

            // Zap�e obsah do v�stupn�ho souboru pomoc� FileStream a k�dov�n� UTF-8 bez BOM
            using (StreamWriter sw = new(new FileStream(filePath, FileMode.Create), new UTF8Encoding(false))) {
                foreach (var line in content) {
                    sw.WriteLine(line);
                }
            }
            // Sets new files last write time to same as the original file
            File.SetLastWriteTimeUtc(filePath, lastWriteTime);
        }

        private void BtStart_Click(object sender, EventArgs e) {
            BtStart.Text = "Na��t�n�...";
            BtStart.Enabled = false;

            // Inicializuje nov� formul�� a skryje se
            FormList formList = new();
            formList.Show();
            Hide();
            // (Tento formul�� se vyp�n� pozd�ji - z�rove� se zav�en�m okna s vyhled�v�n�m)
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e) {
            // Ukon�� aplikaci p�i zav�en� formul��e
            Environment.Exit(0);
        }
    }
}
