namespace Vyhledavac3000 {
    partial class FormList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            DataGridView = new DataGridView();
            TableLPContainer = new TableLayoutPanel();
            TableLPSearchContainer = new TableLayoutPanel();
            TableLPSearch = new TableLayoutPanel();
            LbSearch = new Label();
            LbSearchBy = new Label();
            CbSearchBy = new ComboBox();
            SearchTextBox = new TextBox();
            BtSearch = new Button();
            FlowLPRadioContainsIs = new FlowLayoutPanel();
            RbIs = new RadioButton();
            RbContains = new RadioButton();
            LbFileInfo = new Label();
            KRAJ_KOD = new DataGridViewTextBoxColumn();
            KRAJ_NAZEV = new DataGridViewTextBoxColumn();
            OKRES_KOD = new DataGridViewTextBoxColumn();
            NUTS4 = new DataGridViewTextBoxColumn();
            OKRES_NAZEV = new DataGridViewTextBoxColumn();
            OBEC_KOD = new DataGridViewTextBoxColumn();
            OBEC_NAZEV = new DataGridViewTextBoxColumn();
            KU_KOD = new DataGridViewTextBoxColumn();
            KU_PRAC = new DataGridViewTextBoxColumn();
            KU_NAZEV = new DataGridViewTextBoxColumn();
            MAPA = new DataGridViewTextBoxColumn();
            CISELNA_RADA = new DataGridViewTextBoxColumn();
            PLATNOST_OD = new DataGridViewTextBoxColumn();
            PLATNOST_DO = new DataGridViewTextBoxColumn();
            PRARES_KOD = new DataGridViewTextBoxColumn();
            PRARES_NAZEV = new DataGridViewTextBoxColumn();
            POZNAMKA = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            TableLPContainer.SuspendLayout();
            TableLPSearchContainer.SuspendLayout();
            TableLPSearch.SuspendLayout();
            FlowLPRadioContainsIs.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.BackgroundColor = SystemColors.Control;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { KRAJ_KOD, KRAJ_NAZEV, OKRES_KOD, NUTS4, OKRES_NAZEV, OBEC_KOD, OBEC_NAZEV, KU_KOD, KU_PRAC, KU_NAZEV, MAPA, CISELNA_RADA, PLATNOST_OD, PLATNOST_DO, PRARES_KOD, PRARES_NAZEV, POZNAMKA });
            DataGridView.Dock = DockStyle.Fill;
            DataGridView.Location = new Point(0, 180);
            DataGridView.Margin = new Padding(0);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.Size = new Size(1392, 662);
            DataGridView.TabIndex = 0;
            // 
            // TableLPContainer
            // 
            TableLPContainer.ColumnCount = 1;
            TableLPContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLPContainer.Controls.Add(TableLPSearchContainer, 0, 0);
            TableLPContainer.Controls.Add(DataGridView, 0, 1);
            TableLPContainer.Dock = DockStyle.Fill;
            TableLPContainer.Location = new Point(0, 0);
            TableLPContainer.Margin = new Padding(0);
            TableLPContainer.Name = "TableLPContainer";
            TableLPContainer.RowCount = 2;
            TableLPContainer.RowStyles.Add(new RowStyle());
            TableLPContainer.RowStyles.Add(new RowStyle());
            TableLPContainer.Size = new Size(1392, 782);
            TableLPContainer.TabIndex = 1;
            // 
            // TableLPSearchContainer
            // 
            TableLPSearchContainer.ColumnCount = 3;
            TableLPSearchContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLPSearchContainer.ColumnStyles.Add(new ColumnStyle());
            TableLPSearchContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLPSearchContainer.Controls.Add(TableLPSearch, 1, 1);
            TableLPSearchContainer.Controls.Add(LbFileInfo, 1, 0);
            TableLPSearchContainer.Dock = DockStyle.Fill;
            TableLPSearchContainer.Location = new Point(0, 0);
            TableLPSearchContainer.Margin = new Padding(0);
            TableLPSearchContainer.Name = "TableLPSearchContainer";
            TableLPSearchContainer.RowCount = 2;
            TableLPSearchContainer.RowStyles.Add(new RowStyle());
            TableLPSearchContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLPSearchContainer.Size = new Size(1392, 180);
            TableLPSearchContainer.TabIndex = 1;
            // 
            // TableLPSearch
            // 
            TableLPSearch.ColumnCount = 2;
            TableLPSearch.ColumnStyles.Add(new ColumnStyle());
            TableLPSearch.ColumnStyles.Add(new ColumnStyle());
            TableLPSearch.Controls.Add(LbSearch, 0, 1);
            TableLPSearch.Controls.Add(LbSearchBy, 0, 0);
            TableLPSearch.Controls.Add(CbSearchBy, 1, 0);
            TableLPSearch.Controls.Add(SearchTextBox, 1, 1);
            TableLPSearch.Controls.Add(BtSearch, 1, 3);
            TableLPSearch.Controls.Add(FlowLPRadioContainsIs, 1, 2);
            TableLPSearch.Dock = DockStyle.Fill;
            TableLPSearch.Location = new Point(546, 27);
            TableLPSearch.Margin = new Padding(0);
            TableLPSearch.Name = "TableLPSearch";
            TableLPSearch.RowCount = 5;
            TableLPSearch.RowStyles.Add(new RowStyle());
            TableLPSearch.RowStyles.Add(new RowStyle());
            TableLPSearch.RowStyles.Add(new RowStyle());
            TableLPSearch.RowStyles.Add(new RowStyle());
            TableLPSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLPSearch.Size = new Size(300, 153);
            TableLPSearch.TabIndex = 0;
            // 
            // LbSearch
            // 
            LbSearch.Anchor = AnchorStyles.Right;
            LbSearch.AutoSize = true;
            LbSearch.Location = new Point(0, 36);
            LbSearch.Margin = new Padding(0);
            LbSearch.Name = "LbSearch";
            LbSearch.Size = new Size(45, 15);
            LbSearch.TabIndex = 1;
            LbSearch.Text = "Hledat:";
            // 
            // LbSearchBy
            // 
            LbSearchBy.Anchor = AnchorStyles.Right;
            LbSearchBy.AutoSize = true;
            LbSearchBy.Location = new Point(8, 7);
            LbSearchBy.Margin = new Padding(0);
            LbSearchBy.Name = "LbSearchBy";
            LbSearchBy.Size = new Size(37, 15);
            LbSearchBy.TabIndex = 2;
            LbSearchBy.Text = "Podle";
            // 
            // CbSearchBy
            // 
            CbSearchBy.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CbSearchBy.FormattingEnabled = true;
            CbSearchBy.Items.AddRange(new object[] { "Název/kód obce, Název/kód katas. úz.", "Vše" });
            CbSearchBy.Location = new Point(48, 3);
            CbSearchBy.Name = "CbSearchBy";
            CbSearchBy.Size = new Size(250, 23);
            CbSearchBy.TabIndex = 4;
            CbSearchBy.SelectedIndexChanged += CbSearchBy_SelectedIndexChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Left;
            SearchTextBox.Location = new Point(48, 32);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(250, 23);
            SearchTextBox.TabIndex = 0;
            // 
            // BtSearch
            // 
            BtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtSearch.Location = new Point(127, 86);
            BtSearch.Name = "BtSearch";
            BtSearch.Size = new Size(92, 35);
            BtSearch.TabIndex = 6;
            BtSearch.Text = "Hledat";
            BtSearch.UseVisualStyleBackColor = true;
            BtSearch.Click += BtSearch_Click;
            // 
            // FlowLPRadioContainsIs
            // 
            FlowLPRadioContainsIs.Controls.Add(RbIs);
            FlowLPRadioContainsIs.Controls.Add(RbContains);
            FlowLPRadioContainsIs.Location = new Point(45, 58);
            FlowLPRadioContainsIs.Margin = new Padding(0);
            FlowLPRadioContainsIs.Name = "FlowLPRadioContainsIs";
            FlowLPRadioContainsIs.Size = new Size(255, 25);
            FlowLPRadioContainsIs.TabIndex = 7;
            // 
            // RbIs
            // 
            RbIs.AutoSize = true;
            RbIs.Checked = true;
            RbIs.Location = new Point(3, 3);
            RbIs.Name = "RbIs";
            RbIs.Size = new Size(35, 19);
            RbIs.TabIndex = 0;
            RbIs.TabStop = true;
            RbIs.Text = "Je";
            RbIs.UseVisualStyleBackColor = true;
            // 
            // RbContains
            // 
            RbContains.AutoSize = true;
            RbContains.Location = new Point(44, 3);
            RbContains.Name = "RbContains";
            RbContains.Size = new Size(75, 19);
            RbContains.TabIndex = 1;
            RbContains.TabStop = true;
            RbContains.Text = "Obsahuje";
            RbContains.UseVisualStyleBackColor = true;
            // 
            // LbFileInfo
            // 
            LbFileInfo.Anchor = AnchorStyles.None;
            LbFileInfo.AutoSize = true;
            LbFileInfo.Location = new Point(639, 12);
            LbFileInfo.Margin = new Padding(3, 12, 3, 0);
            LbFileInfo.Name = "LbFileInfo";
            LbFileInfo.Size = new Size(113, 15);
            LbFileInfo.TabIndex = 1;
            LbFileInfo.Text = "Informace o hledání";
            // 
            // KRAJ_KOD
            // 
            KRAJ_KOD.HeaderText = "Kód kraje";
            KRAJ_KOD.Name = "KRAJ_KOD";
            KRAJ_KOD.ReadOnly = true;
            KRAJ_KOD.Width = 75;
            // 
            // KRAJ_NAZEV
            // 
            KRAJ_NAZEV.HeaderText = "Název kraje";
            KRAJ_NAZEV.Name = "KRAJ_NAZEV";
            KRAJ_NAZEV.ReadOnly = true;
            KRAJ_NAZEV.Width = 160;
            // 
            // OKRES_KOD
            // 
            OKRES_KOD.HeaderText = "Kód okresu";
            OKRES_KOD.Name = "OKRES_KOD";
            OKRES_KOD.ReadOnly = true;
            OKRES_KOD.Width = 75;
            // 
            // NUTS4
            // 
            NUTS4.HeaderText = "Kód okresu NUTS4";
            NUTS4.Name = "NUTS4";
            NUTS4.ReadOnly = true;
            NUTS4.Width = 75;
            // 
            // OKRES_NAZEV
            // 
            OKRES_NAZEV.HeaderText = "Název okresu";
            OKRES_NAZEV.Name = "OKRES_NAZEV";
            OKRES_NAZEV.ReadOnly = true;
            OKRES_NAZEV.Width = 90;
            // 
            // OBEC_KOD
            // 
            OBEC_KOD.HeaderText = "Kód obce (ZUI)";
            OBEC_KOD.Name = "OBEC_KOD";
            OBEC_KOD.ReadOnly = true;
            OBEC_KOD.Width = 75;
            // 
            // OBEC_NAZEV
            // 
            OBEC_NAZEV.HeaderText = "Název obce";
            OBEC_NAZEV.Name = "OBEC_NAZEV";
            OBEC_NAZEV.ReadOnly = true;
            OBEC_NAZEV.Width = 140;
            // 
            // KU_KOD
            // 
            KU_KOD.HeaderText = "Kód katas. území";
            KU_KOD.Name = "KU_KOD";
            KU_KOD.ReadOnly = true;
            KU_KOD.Width = 75;
            // 
            // KU_PRAC
            // 
            KU_PRAC.HeaderText = "Prac. číslo katas. území";
            KU_PRAC.Name = "KU_PRAC";
            KU_PRAC.ReadOnly = true;
            KU_PRAC.Width = 90;
            // 
            // KU_NAZEV
            // 
            KU_NAZEV.HeaderText = "Název katas. území";
            KU_NAZEV.Name = "KU_NAZEV";
            KU_NAZEV.ReadOnly = true;
            KU_NAZEV.Width = 140;
            // 
            // MAPA
            // 
            MAPA.HeaderText = "Mapa";
            MAPA.Name = "MAPA";
            MAPA.ReadOnly = true;
            MAPA.Width = 55;
            // 
            // CISELNA_RADA
            // 
            CISELNA_RADA.HeaderText = "Číselná řada";
            CISELNA_RADA.Name = "CISELNA_RADA";
            CISELNA_RADA.ReadOnly = true;
            CISELNA_RADA.Width = 65;
            // 
            // PLATNOST_OD
            // 
            PLATNOST_OD.HeaderText = "Datum vzniku katas. území";
            PLATNOST_OD.Name = "PLATNOST_OD";
            PLATNOST_OD.ReadOnly = true;
            PLATNOST_OD.Width = 95;
            // 
            // PLATNOST_DO
            // 
            PLATNOST_DO.HeaderText = "Datum zániku katas. území";
            PLATNOST_DO.Name = "PLATNOST_DO";
            PLATNOST_DO.ReadOnly = true;
            PLATNOST_DO.Width = 95;
            // 
            // PRARES_KOD
            // 
            PRARES_KOD.HeaderText = "Kód prac. resortu";
            PRARES_KOD.Name = "PRARES_KOD";
            PRARES_KOD.ReadOnly = true;
            PRARES_KOD.Width = 55;
            // 
            // PRARES_NAZEV
            // 
            PRARES_NAZEV.HeaderText = "Název prac. resortu ČUZK";
            PRARES_NAZEV.Name = "PRARES_NAZEV";
            PRARES_NAZEV.ReadOnly = true;
            PRARES_NAZEV.Width = 160;
            // 
            // POZNAMKA
            // 
            POZNAMKA.HeaderText = "Poznámka";
            POZNAMKA.Name = "POZNAMKA";
            POZNAMKA.ReadOnly = true;
            POZNAMKA.Width = 140;
            // 
            // FormList
            // 
            AcceptButton = BtSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 782);
            Controls.Add(TableLPContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(331, 241);
            Name = "FormList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vyledávač 3000";
            FormClosing += FormList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            TableLPContainer.ResumeLayout(false);
            TableLPSearchContainer.ResumeLayout(false);
            TableLPSearchContainer.PerformLayout();
            TableLPSearch.ResumeLayout(false);
            TableLPSearch.PerformLayout();
            FlowLPRadioContainsIs.ResumeLayout(false);
            FlowLPRadioContainsIs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridView;
        private TableLayoutPanel TableLPContainer;
        private TableLayoutPanel TableLPSearchContainer;
        private TableLayoutPanel TableLPSearch;
        private Label LbSearch;
        private TextBox SearchTextBox;
        private Label LbSearchBy;
        private ComboBox CbSearchBy;
        private Label LbFileInfo;
        private Button BtSearch;
        private FlowLayoutPanel FlowLPRadioContainsIs;
        private RadioButton RbIs;
        private RadioButton RbContains;
        private DataGridViewTextBoxColumn KRAJ_KOD;
        private DataGridViewTextBoxColumn KRAJ_NAZEV;
        private DataGridViewTextBoxColumn OKRES_KOD;
        private DataGridViewTextBoxColumn NUTS4;
        private DataGridViewTextBoxColumn OKRES_NAZEV;
        private DataGridViewTextBoxColumn OBEC_KOD;
        private DataGridViewTextBoxColumn OBEC_NAZEV;
        private DataGridViewTextBoxColumn KU_KOD;
        private DataGridViewTextBoxColumn KU_PRAC;
        private DataGridViewTextBoxColumn KU_NAZEV;
        private DataGridViewTextBoxColumn MAPA;
        private DataGridViewTextBoxColumn CISELNA_RADA;
        private DataGridViewTextBoxColumn PLATNOST_OD;
        private DataGridViewTextBoxColumn PLATNOST_DO;
        private DataGridViewTextBoxColumn PRARES_KOD;
        private DataGridViewTextBoxColumn PRARES_NAZEV;
        private DataGridViewTextBoxColumn POZNAMKA;
    }
}