namespace Vyhledavac3000 {
    partial class FormStart {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            LbTitle = new Label();
            TableLP1 = new TableLayoutPanel();
            TableLPContainer = new TableLayoutPanel();
            LbFileName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtSvnLoad = new Button();
            BtFileSelect = new Button();
            BtStart = new Button();
            LbVersion = new Label();
            label1 = new Label();
            OpenFileDialogCsv = new OpenFileDialog();
            TableLP1.SuspendLayout();
            TableLPContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LbTitle
            // 
            LbTitle.Anchor = AnchorStyles.None;
            LbTitle.AutoSize = true;
            LbTitle.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            LbTitle.Location = new Point(103, 30);
            LbTitle.Margin = new Padding(0, 30, 0, 3);
            LbTitle.Name = "LbTitle";
            LbTitle.Size = new Size(248, 41);
            LbTitle.TabIndex = 0;
            LbTitle.Text = "Vyhledávač 3000";
            // 
            // TableLP1
            // 
            TableLP1.ColumnCount = 1;
            TableLP1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLP1.Controls.Add(LbTitle, 0, 0);
            TableLP1.Controls.Add(TableLPContainer, 0, 2);
            TableLP1.Controls.Add(label1, 0, 1);
            TableLP1.Dock = DockStyle.Fill;
            TableLP1.Location = new Point(0, 0);
            TableLP1.Margin = new Padding(0);
            TableLP1.Name = "TableLP1";
            TableLP1.RowCount = 3;
            TableLP1.RowStyles.Add(new RowStyle());
            TableLP1.RowStyles.Add(new RowStyle());
            TableLP1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLP1.Size = new Size(455, 348);
            TableLP1.TabIndex = 1;
            // 
            // TableLPContainer
            // 
            TableLPContainer.ColumnCount = 1;
            TableLPContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLPContainer.Controls.Add(LbFileName, 0, 1);
            TableLPContainer.Controls.Add(tableLayoutPanel1, 0, 0);
            TableLPContainer.Controls.Add(BtStart, 0, 2);
            TableLPContainer.Controls.Add(LbVersion, 0, 3);
            TableLPContainer.Dock = DockStyle.Fill;
            TableLPContainer.Location = new Point(0, 98);
            TableLPContainer.Margin = new Padding(0);
            TableLPContainer.Name = "TableLPContainer";
            TableLPContainer.RowCount = 4;
            TableLPContainer.RowStyles.Add(new RowStyle());
            TableLPContainer.RowStyles.Add(new RowStyle());
            TableLPContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLPContainer.RowStyles.Add(new RowStyle());
            TableLPContainer.Size = new Size(455, 250);
            TableLPContainer.TabIndex = 1;
            // 
            // LbFileName
            // 
            LbFileName.Anchor = AnchorStyles.None;
            LbFileName.AutoSize = true;
            LbFileName.Location = new Point(227, 52);
            LbFileName.Margin = new Padding(3, 3, 3, 12);
            LbFileName.Name = "LbFileName";
            LbFileName.Size = new Size(0, 15);
            LbFileName.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(BtSvnLoad, 0, 0);
            tableLayoutPanel1.Controls.Add(BtFileSelect, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(455, 49);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // BtSvnLoad
            // 
            BtSvnLoad.Anchor = AnchorStyles.Right;
            BtSvnLoad.Location = new Point(103, 12);
            BtSvnLoad.Margin = new Padding(3, 12, 3, 3);
            BtSvnLoad.Name = "BtSvnLoad";
            BtSvnLoad.Size = new Size(121, 34);
            BtSvnLoad.TabIndex = 0;
            BtSvnLoad.Text = "Nahrát ze SVN";
            BtSvnLoad.UseVisualStyleBackColor = true;
            BtSvnLoad.Click += BtSvnLoad_Click;
            // 
            // BtFileSelect
            // 
            BtFileSelect.Anchor = AnchorStyles.Left;
            BtFileSelect.Location = new Point(230, 12);
            BtFileSelect.Margin = new Padding(3, 12, 3, 3);
            BtFileSelect.Name = "BtFileSelect";
            BtFileSelect.Size = new Size(121, 34);
            BtFileSelect.TabIndex = 1;
            BtFileSelect.Text = "Vybrat soubor";
            BtFileSelect.UseVisualStyleBackColor = true;
            BtFileSelect.Click += BtFileSelect_Click;
            // 
            // BtStart
            // 
            BtStart.Anchor = AnchorStyles.Top;
            BtStart.Enabled = false;
            BtStart.Location = new Point(163, 97);
            BtStart.Margin = new Padding(3, 18, 3, 3);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(129, 67);
            BtStart.TabIndex = 3;
            BtStart.Text = "Spustit";
            BtStart.UseVisualStyleBackColor = true;
            BtStart.Click += BtStart_Click;
            // 
            // LbVersion
            // 
            LbVersion.Anchor = AnchorStyles.None;
            LbVersion.AutoSize = true;
            LbVersion.ForeColor = SystemColors.GrayText;
            LbVersion.Location = new Point(166, 232);
            LbVersion.Margin = new Padding(3, 0, 3, 3);
            LbVersion.Name = "LbVersion";
            LbVersion.Size = new Size(122, 15);
            LbVersion.TabIndex = 4;
            LbVersion.Text = "Aktuální verze - v1.0.0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(112, 74);
            label1.Margin = new Padding(3, 0, 3, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 2;
            label1.Text = "Vyhledávání v aktuálním seznamu Identcis";
            // 
            // OpenFileDialogCsv
            // 
            OpenFileDialogCsv.DefaultExt = "csv";
            OpenFileDialogCsv.Filter = "Soubor CSV|*.csv|Všechny soubory|*.*";
            OpenFileDialogCsv.ShowReadOnly = true;
            OpenFileDialogCsv.Title = "Vyberte soubor CSV k prohledání";
            // 
            // FormStart
            // 
            AcceptButton = BtStart;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 348);
            Controls.Add(TableLP1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vyledávač 3000";
            FormClosing += FormStart_FormClosing;
            TableLP1.ResumeLayout(false);
            TableLP1.PerformLayout();
            TableLPContainer.ResumeLayout(false);
            TableLPContainer.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LbTitle;
        private TableLayoutPanel TableLP1;
        private TableLayoutPanel TableLPContainer;
        private Button BtFileSelect;
        private Label LbFileName;
        private OpenFileDialog OpenFileDialogCsv;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtSvnLoad;
        private Button BtStart;
        private Label label1;
        private Label LbVersion;
    }
}
