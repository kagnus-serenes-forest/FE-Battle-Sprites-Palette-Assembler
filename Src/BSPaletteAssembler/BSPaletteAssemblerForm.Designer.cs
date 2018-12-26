namespace BSPaletteAssembler
{
    partial class BSPaletteAssemblerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSPaletteAssemblerForm));
            this.PalettesTabControl = new System.Windows.Forms.TabControl();
            this.PlayerPaletteTab = new System.Windows.Forms.TabPage();
            this.PlayerPaletteVisualizer = new BSPaletteAssembler.BSPaletteVisualizer();
            this.EnemyPaletteTab = new System.Windows.Forms.TabPage();
            this.EnemyPaletteVisualizer = new BSPaletteAssembler.BSPaletteVisualizer();
            this.NPCPaletteTab = new System.Windows.Forms.TabPage();
            this.NPCPaletteVisualizer = new BSPaletteAssembler.BSPaletteVisualizer();
            this.Player4PaletteTab = new System.Windows.Forms.TabPage();
            this.Player4PaletteVisualizer = new BSPaletteAssembler.BSPaletteVisualizer();
            this.Player1PaletteTab = new System.Windows.Forms.TabPage();
            this.Player1PaletteVisualizer = new BSPaletteAssembler.BSPaletteVisualizer();
            this.ClipboardImporter = new System.Windows.Forms.Button();
            this.ClipboardExporter = new System.Windows.Forms.Button();
            this.FileSaver = new System.Windows.Forms.Button();
            this.OffsetSelector = new System.Windows.Forms.NumericUpDown();
            this.ResetCurrentPalette = new System.Windows.Forms.Button();
            this.ResetAll = new System.Windows.Forms.Button();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.OutputFileGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveROMButton = new System.Windows.Forms.Button();
            this.IsAROMCkBx = new System.Windows.Forms.CheckBox();
            this.GetOutputFile = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.extractEntryButton = new System.Windows.Forms.Button();
            this.ClipboardGroupBox = new System.Windows.Forms.GroupBox();
            this.exportExtractedIndexButton = new System.Windows.Forms.Button();
            this.ResetGroupBox = new System.Windows.Forms.GroupBox();
            this.defaultPaletteBox = new System.Windows.Forms.GroupBox();
            this.currentDefaultPaletteNameLabel = new System.Windows.Forms.Label();
            this.currentDefaultTextLabel = new System.Windows.Forms.Label();
            this.defaultPaletteButton = new System.Windows.Forms.Button();
            this.PaletteEntrySelector = new System.Windows.Forms.ComboBox();
            this.FE6Radio = new System.Windows.Forms.RadioButton();
            this.FE7Radio = new System.Windows.Forms.RadioButton();
            this.FE8Radio = new System.Windows.Forms.RadioButton();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.paletteEntriesGroupBox = new System.Windows.Forms.GroupBox();
            this.insertEntryButton = new System.Windows.Forms.Button();
            this.autoExtractCheckBox = new System.Windows.Forms.CheckBox();
            this.mTabControl = new System.Windows.Forms.TabControl();
            this.ImportedTab = new System.Windows.Forms.TabPage();
            this.ExtractedTab = new System.Windows.Forms.TabPage();
            this.extractedPaletteTabControl = new System.Windows.Forms.TabControl();
            this.extractedPlayerTab = new System.Windows.Forms.TabPage();
            this.extractedPlayerVisu = new BSPaletteAssembler.BSPaletteVisualizer();
            this.extractedEnemyTab = new System.Windows.Forms.TabPage();
            this.extractedEnemyVisu = new BSPaletteAssembler.BSPaletteVisualizer();
            this.extractedNpcTab = new System.Windows.Forms.TabPage();
            this.extractedNpcVisu = new BSPaletteAssembler.BSPaletteVisualizer();
            this.extractedPlayer4LATab = new System.Windows.Forms.TabPage();
            this.extractedPlayer4LAVisu = new BSPaletteAssembler.BSPaletteVisualizer();
            this.extractedPlayer1LATab = new System.Windows.Forms.TabPage();
            this.extractedPlayer1LAVisu = new BSPaletteAssembler.BSPaletteVisualizer();
            this.PalettesTabControl.SuspendLayout();
            this.PlayerPaletteTab.SuspendLayout();
            this.EnemyPaletteTab.SuspendLayout();
            this.NPCPaletteTab.SuspendLayout();
            this.Player4PaletteTab.SuspendLayout();
            this.Player1PaletteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetSelector)).BeginInit();
            this.OutputFileGroupBox.SuspendLayout();
            this.ClipboardGroupBox.SuspendLayout();
            this.ResetGroupBox.SuspendLayout();
            this.defaultPaletteBox.SuspendLayout();
            this.gameGroupBox.SuspendLayout();
            this.paletteEntriesGroupBox.SuspendLayout();
            this.mTabControl.SuspendLayout();
            this.ImportedTab.SuspendLayout();
            this.ExtractedTab.SuspendLayout();
            this.extractedPaletteTabControl.SuspendLayout();
            this.extractedPlayerTab.SuspendLayout();
            this.extractedEnemyTab.SuspendLayout();
            this.extractedNpcTab.SuspendLayout();
            this.extractedPlayer4LATab.SuspendLayout();
            this.extractedPlayer1LATab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PalettesTabControl
            // 
            this.PalettesTabControl.Controls.Add(this.PlayerPaletteTab);
            this.PalettesTabControl.Controls.Add(this.EnemyPaletteTab);
            this.PalettesTabControl.Controls.Add(this.NPCPaletteTab);
            this.PalettesTabControl.Controls.Add(this.Player4PaletteTab);
            this.PalettesTabControl.Controls.Add(this.Player1PaletteTab);
            this.PalettesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalettesTabControl.Location = new System.Drawing.Point(3, 3);
            this.PalettesTabControl.Name = "PalettesTabControl";
            this.PalettesTabControl.SelectedIndex = 0;
            this.PalettesTabControl.Size = new System.Drawing.Size(580, 131);
            this.PalettesTabControl.TabIndex = 1;
            // 
            // PlayerPaletteTab
            // 
            this.PlayerPaletteTab.Controls.Add(this.PlayerPaletteVisualizer);
            this.PlayerPaletteTab.Location = new System.Drawing.Point(4, 22);
            this.PlayerPaletteTab.Name = "PlayerPaletteTab";
            this.PlayerPaletteTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerPaletteTab.Size = new System.Drawing.Size(572, 105);
            this.PlayerPaletteTab.TabIndex = 0;
            this.PlayerPaletteTab.Text = "Player";
            this.PlayerPaletteTab.UseVisualStyleBackColor = true;
            // 
            // PlayerPaletteVisualizer
            // 
            this.PlayerPaletteVisualizer.ColorsLoaded = false;
            this.PlayerPaletteVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerPaletteVisualizer.Location = new System.Drawing.Point(3, 3);
            this.PlayerPaletteVisualizer.Name = "PlayerPaletteVisualizer";
            this.PlayerPaletteVisualizer.Size = new System.Drawing.Size(566, 99);
            this.PlayerPaletteVisualizer.TabIndex = 0;
            // 
            // EnemyPaletteTab
            // 
            this.EnemyPaletteTab.Controls.Add(this.EnemyPaletteVisualizer);
            this.EnemyPaletteTab.Location = new System.Drawing.Point(4, 22);
            this.EnemyPaletteTab.Name = "EnemyPaletteTab";
            this.EnemyPaletteTab.Padding = new System.Windows.Forms.Padding(3);
            this.EnemyPaletteTab.Size = new System.Drawing.Size(572, 105);
            this.EnemyPaletteTab.TabIndex = 1;
            this.EnemyPaletteTab.Text = "Enemy";
            this.EnemyPaletteTab.UseVisualStyleBackColor = true;
            // 
            // EnemyPaletteVisualizer
            // 
            this.EnemyPaletteVisualizer.ColorsLoaded = false;
            this.EnemyPaletteVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyPaletteVisualizer.Location = new System.Drawing.Point(3, 3);
            this.EnemyPaletteVisualizer.Name = "EnemyPaletteVisualizer";
            this.EnemyPaletteVisualizer.Size = new System.Drawing.Size(566, 99);
            this.EnemyPaletteVisualizer.TabIndex = 0;
            // 
            // NPCPaletteTab
            // 
            this.NPCPaletteTab.Controls.Add(this.NPCPaletteVisualizer);
            this.NPCPaletteTab.Location = new System.Drawing.Point(4, 22);
            this.NPCPaletteTab.Name = "NPCPaletteTab";
            this.NPCPaletteTab.Padding = new System.Windows.Forms.Padding(3);
            this.NPCPaletteTab.Size = new System.Drawing.Size(572, 105);
            this.NPCPaletteTab.TabIndex = 2;
            this.NPCPaletteTab.Text = "NPC";
            this.NPCPaletteTab.UseVisualStyleBackColor = true;
            // 
            // NPCPaletteVisualizer
            // 
            this.NPCPaletteVisualizer.ColorsLoaded = false;
            this.NPCPaletteVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NPCPaletteVisualizer.Location = new System.Drawing.Point(3, 3);
            this.NPCPaletteVisualizer.Name = "NPCPaletteVisualizer";
            this.NPCPaletteVisualizer.Size = new System.Drawing.Size(566, 99);
            this.NPCPaletteVisualizer.TabIndex = 0;
            // 
            // Player4PaletteTab
            // 
            this.Player4PaletteTab.Controls.Add(this.Player4PaletteVisualizer);
            this.Player4PaletteTab.Location = new System.Drawing.Point(4, 22);
            this.Player4PaletteTab.Name = "Player4PaletteTab";
            this.Player4PaletteTab.Padding = new System.Windows.Forms.Padding(3);
            this.Player4PaletteTab.Size = new System.Drawing.Size(572, 105);
            this.Player4PaletteTab.TabIndex = 3;
            this.Player4PaletteTab.Text = "Player4 link arena";
            this.Player4PaletteTab.UseVisualStyleBackColor = true;
            // 
            // Player4PaletteVisualizer
            // 
            this.Player4PaletteVisualizer.ColorsLoaded = false;
            this.Player4PaletteVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player4PaletteVisualizer.Location = new System.Drawing.Point(3, 3);
            this.Player4PaletteVisualizer.Name = "Player4PaletteVisualizer";
            this.Player4PaletteVisualizer.Size = new System.Drawing.Size(566, 99);
            this.Player4PaletteVisualizer.TabIndex = 0;
            // 
            // Player1PaletteTab
            // 
            this.Player1PaletteTab.Controls.Add(this.Player1PaletteVisualizer);
            this.Player1PaletteTab.Location = new System.Drawing.Point(4, 22);
            this.Player1PaletteTab.Name = "Player1PaletteTab";
            this.Player1PaletteTab.Padding = new System.Windows.Forms.Padding(3);
            this.Player1PaletteTab.Size = new System.Drawing.Size(572, 105);
            this.Player1PaletteTab.TabIndex = 4;
            this.Player1PaletteTab.Text = "Player1 link arena";
            this.Player1PaletteTab.UseVisualStyleBackColor = true;
            // 
            // Player1PaletteVisualizer
            // 
            this.Player1PaletteVisualizer.ColorsLoaded = false;
            this.Player1PaletteVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1PaletteVisualizer.Location = new System.Drawing.Point(3, 3);
            this.Player1PaletteVisualizer.Name = "Player1PaletteVisualizer";
            this.Player1PaletteVisualizer.Size = new System.Drawing.Size(566, 99);
            this.Player1PaletteVisualizer.TabIndex = 0;
            // 
            // ClipboardImporter
            // 
            this.ClipboardImporter.Location = new System.Drawing.Point(6, 17);
            this.ClipboardImporter.Name = "ClipboardImporter";
            this.ClipboardImporter.Size = new System.Drawing.Size(121, 23);
            this.ClipboardImporter.TabIndex = 0;
            this.ClipboardImporter.Text = "Import from clipboard";
            this.ClipboardImporter.UseVisualStyleBackColor = true;
            this.ClipboardImporter.Click += new System.EventHandler(this.ClipboardImporter_Click);
            // 
            // ClipboardExporter
            // 
            this.ClipboardExporter.Location = new System.Drawing.Point(6, 50);
            this.ClipboardExporter.Name = "ClipboardExporter";
            this.ClipboardExporter.Size = new System.Drawing.Size(121, 23);
            this.ClipboardExporter.TabIndex = 1;
            this.ClipboardExporter.Text = "Compress to clipboard";
            this.ClipboardExporter.UseVisualStyleBackColor = true;
            this.ClipboardExporter.Click += new System.EventHandler(this.ClipboardExporter_Click);
            // 
            // FileSaver
            // 
            this.FileSaver.Enabled = false;
            this.FileSaver.Location = new System.Drawing.Point(148, 47);
            this.FileSaver.Name = "FileSaver";
            this.FileSaver.Size = new System.Drawing.Size(121, 23);
            this.FileSaver.TabIndex = 3;
            this.FileSaver.Text = "Compress to file";
            this.FileSaver.UseVisualStyleBackColor = true;
            this.FileSaver.Click += new System.EventHandler(this.FileSaver_Click);
            // 
            // OffsetSelector
            // 
            this.OffsetSelector.Enabled = false;
            this.OffsetSelector.Hexadecimal = true;
            this.OffsetSelector.Location = new System.Drawing.Point(47, 50);
            this.OffsetSelector.Maximum = new decimal(new int[] {
            -1610612992,
            0,
            0,
            0});
            this.OffsetSelector.Name = "OffsetSelector";
            this.OffsetSelector.Size = new System.Drawing.Size(95, 20);
            this.OffsetSelector.TabIndex = 7;
            this.OffsetSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResetCurrentPalette
            // 
            this.ResetCurrentPalette.Location = new System.Drawing.Point(6, 16);
            this.ResetCurrentPalette.Name = "ResetCurrentPalette";
            this.ResetCurrentPalette.Size = new System.Drawing.Size(121, 23);
            this.ResetCurrentPalette.TabIndex = 5;
            this.ResetCurrentPalette.Text = "Reset current index";
            this.ResetCurrentPalette.UseVisualStyleBackColor = true;
            this.ResetCurrentPalette.Click += new System.EventHandler(this.ResetCurrentPalette_Click);
            // 
            // ResetAll
            // 
            this.ResetAll.Location = new System.Drawing.Point(6, 46);
            this.ResetAll.Name = "ResetAll";
            this.ResetAll.Size = new System.Drawing.Size(121, 23);
            this.ResetAll.TabIndex = 6;
            this.ResetAll.Text = "Reset all indexes";
            this.ResetAll.UseVisualStyleBackColor = true;
            this.ResetAll.Click += new System.EventHandler(this.ResetAll_Click);
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Location = new System.Drawing.Point(6, 55);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(35, 13);
            this.OffsetLabel.TabIndex = 8;
            this.OffsetLabel.Text = "Offset";
            // 
            // OutputFileGroupBox
            // 
            this.OutputFileGroupBox.Controls.Add(this.SaveROMButton);
            this.OutputFileGroupBox.Controls.Add(this.IsAROMCkBx);
            this.OutputFileGroupBox.Controls.Add(this.GetOutputFile);
            this.OutputFileGroupBox.Controls.Add(this.PathTextBox);
            this.OutputFileGroupBox.Controls.Add(this.OffsetLabel);
            this.OutputFileGroupBox.Controls.Add(this.OffsetSelector);
            this.OutputFileGroupBox.Controls.Add(this.FileSaver);
            this.OutputFileGroupBox.Location = new System.Drawing.Point(285, 12);
            this.OutputFileGroupBox.Name = "OutputFileGroupBox";
            this.OutputFileGroupBox.Size = new System.Drawing.Size(277, 108);
            this.OutputFileGroupBox.TabIndex = 9;
            this.OutputFileGroupBox.TabStop = false;
            this.OutputFileGroupBox.Text = "Output file";
            // 
            // SaveROMButton
            // 
            this.SaveROMButton.Enabled = false;
            this.SaveROMButton.Location = new System.Drawing.Point(193, 77);
            this.SaveROMButton.Name = "SaveROMButton";
            this.SaveROMButton.Size = new System.Drawing.Size(75, 23);
            this.SaveROMButton.TabIndex = 14;
            this.SaveROMButton.Text = "Save ROM";
            this.SaveROMButton.UseVisualStyleBackColor = true;
            this.SaveROMButton.Click += new System.EventHandler(this.SaveROMButton_Click);
            // 
            // IsAROMCkBx
            // 
            this.IsAROMCkBx.AutoSize = true;
            this.IsAROMCkBx.Checked = true;
            this.IsAROMCkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsAROMCkBx.Location = new System.Drawing.Point(9, 88);
            this.IsAROMCkBx.Name = "IsAROMCkBx";
            this.IsAROMCkBx.Size = new System.Drawing.Size(77, 17);
            this.IsAROMCkBx.TabIndex = 11;
            this.IsAROMCkBx.Text = "Is a ROM?";
            this.IsAROMCkBx.UseVisualStyleBackColor = true;
            this.IsAROMCkBx.CheckedChanged += new System.EventHandler(this.IsAROMCkBx_CheckedChanged);
            // 
            // GetOutputFile
            // 
            this.GetOutputFile.Location = new System.Drawing.Point(194, 17);
            this.GetOutputFile.Name = "GetOutputFile";
            this.GetOutputFile.Size = new System.Drawing.Size(75, 23);
            this.GetOutputFile.TabIndex = 2;
            this.GetOutputFile.Text = "Browse...";
            this.GetOutputFile.UseVisualStyleBackColor = true;
            this.GetOutputFile.Click += new System.EventHandler(this.GetOutputFile_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(8, 19);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(168, 20);
            this.PathTextBox.TabIndex = 13;
            // 
            // extractEntryButton
            // 
            this.extractEntryButton.AutoSize = true;
            this.extractEntryButton.Location = new System.Drawing.Point(158, 74);
            this.extractEntryButton.Name = "extractEntryButton";
            this.extractEntryButton.Size = new System.Drawing.Size(111, 23);
            this.extractEntryButton.TabIndex = 12;
            this.extractEntryButton.Text = "Extract palette entry";
            this.extractEntryButton.UseVisualStyleBackColor = true;
            this.extractEntryButton.Click += new System.EventHandler(this.extractEntryButton_Click);
            // 
            // ClipboardGroupBox
            // 
            this.ClipboardGroupBox.Controls.Add(this.exportExtractedIndexButton);
            this.ClipboardGroupBox.Controls.Add(this.ClipboardImporter);
            this.ClipboardGroupBox.Controls.Add(this.ClipboardExporter);
            this.ClipboardGroupBox.Location = new System.Drawing.Point(7, 12);
            this.ClipboardGroupBox.Name = "ClipboardGroupBox";
            this.ClipboardGroupBox.Size = new System.Drawing.Size(132, 118);
            this.ClipboardGroupBox.TabIndex = 10;
            this.ClipboardGroupBox.TabStop = false;
            this.ClipboardGroupBox.Text = "Clipboard";
            // 
            // exportExtractedIndexButton
            // 
            this.exportExtractedIndexButton.Enabled = false;
            this.exportExtractedIndexButton.Location = new System.Drawing.Point(6, 82);
            this.exportExtractedIndexButton.Name = "exportExtractedIndexButton";
            this.exportExtractedIndexButton.Size = new System.Drawing.Size(121, 23);
            this.exportExtractedIndexButton.TabIndex = 2;
            this.exportExtractedIndexButton.Text = "Export extracted index";
            this.exportExtractedIndexButton.UseVisualStyleBackColor = true;
            this.exportExtractedIndexButton.Click += new System.EventHandler(this.ExportExtractedIndexButton_Click);
            // 
            // ResetGroupBox
            // 
            this.ResetGroupBox.Controls.Add(this.ResetCurrentPalette);
            this.ResetGroupBox.Controls.Add(this.ResetAll);
            this.ResetGroupBox.Location = new System.Drawing.Point(145, 12);
            this.ResetGroupBox.Name = "ResetGroupBox";
            this.ResetGroupBox.Size = new System.Drawing.Size(134, 80);
            this.ResetGroupBox.TabIndex = 11;
            this.ResetGroupBox.TabStop = false;
            this.ResetGroupBox.Text = "Reset";
            // 
            // defaultPaletteBox
            // 
            this.defaultPaletteBox.Controls.Add(this.currentDefaultPaletteNameLabel);
            this.defaultPaletteBox.Controls.Add(this.currentDefaultTextLabel);
            this.defaultPaletteBox.Controls.Add(this.defaultPaletteButton);
            this.defaultPaletteBox.Location = new System.Drawing.Point(7, 136);
            this.defaultPaletteBox.Name = "defaultPaletteBox";
            this.defaultPaletteBox.Size = new System.Drawing.Size(164, 91);
            this.defaultPaletteBox.TabIndex = 12;
            this.defaultPaletteBox.TabStop = false;
            this.defaultPaletteBox.Text = "Default index";
            // 
            // currentDefaultPaletteNameLabel
            // 
            this.currentDefaultPaletteNameLabel.AutoSize = true;
            this.currentDefaultPaletteNameLabel.Location = new System.Drawing.Point(6, 69);
            this.currentDefaultPaletteNameLabel.Name = "currentDefaultPaletteNameLabel";
            this.currentDefaultPaletteNameLabel.Size = new System.Drawing.Size(36, 13);
            this.currentDefaultPaletteNameLabel.TabIndex = 2;
            this.currentDefaultPaletteNameLabel.Text = "Player";
            // 
            // currentDefaultTextLabel
            // 
            this.currentDefaultTextLabel.AutoSize = true;
            this.currentDefaultTextLabel.Location = new System.Drawing.Point(7, 50);
            this.currentDefaultTextLabel.Name = "currentDefaultTextLabel";
            this.currentDefaultTextLabel.Size = new System.Drawing.Size(110, 13);
            this.currentDefaultTextLabel.TabIndex = 1;
            this.currentDefaultTextLabel.Text = "Current default index :";
            // 
            // defaultPaletteButton
            // 
            this.defaultPaletteButton.AutoSize = true;
            this.defaultPaletteButton.Location = new System.Drawing.Point(6, 20);
            this.defaultPaletteButton.Name = "defaultPaletteButton";
            this.defaultPaletteButton.Size = new System.Drawing.Size(153, 23);
            this.defaultPaletteButton.TabIndex = 4;
            this.defaultPaletteButton.Text = "Set current index as default";
            this.defaultPaletteButton.UseVisualStyleBackColor = true;
            this.defaultPaletteButton.Click += new System.EventHandler(this.defaultPaletteButton_Click);
            // 
            // PaletteEntrySelector
            // 
            this.PaletteEntrySelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PaletteEntrySelector.FormattingEnabled = true;
            this.PaletteEntrySelector.Location = new System.Drawing.Point(9, 18);
            this.PaletteEntrySelector.Name = "PaletteEntrySelector";
            this.PaletteEntrySelector.Size = new System.Drawing.Size(260, 21);
            this.PaletteEntrySelector.TabIndex = 12;
            // 
            // FE6Radio
            // 
            this.FE6Radio.AutoSize = true;
            this.FE6Radio.Location = new System.Drawing.Point(6, 19);
            this.FE6Radio.Name = "FE6Radio";
            this.FE6Radio.Size = new System.Drawing.Size(44, 17);
            this.FE6Radio.TabIndex = 13;
            this.FE6Radio.Text = "FE6";
            this.FE6Radio.UseVisualStyleBackColor = true;
            this.FE6Radio.CheckedChanged += new System.EventHandler(this.SelectedGameChanged);
            // 
            // FE7Radio
            // 
            this.FE7Radio.AutoSize = true;
            this.FE7Radio.Checked = true;
            this.FE7Radio.Location = new System.Drawing.Point(6, 39);
            this.FE7Radio.Name = "FE7Radio";
            this.FE7Radio.Size = new System.Drawing.Size(44, 17);
            this.FE7Radio.TabIndex = 14;
            this.FE7Radio.TabStop = true;
            this.FE7Radio.Text = "FE7";
            this.FE7Radio.UseVisualStyleBackColor = true;
            this.FE7Radio.CheckedChanged += new System.EventHandler(this.SelectedGameChanged);
            // 
            // FE8Radio
            // 
            this.FE8Radio.AutoSize = true;
            this.FE8Radio.Location = new System.Drawing.Point(6, 59);
            this.FE8Radio.Name = "FE8Radio";
            this.FE8Radio.Size = new System.Drawing.Size(44, 17);
            this.FE8Radio.TabIndex = 15;
            this.FE8Radio.Text = "FE8";
            this.FE8Radio.UseVisualStyleBackColor = true;
            this.FE8Radio.CheckedChanged += new System.EventHandler(this.SelectedGameChanged);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.FE6Radio);
            this.gameGroupBox.Controls.Add(this.FE8Radio);
            this.gameGroupBox.Controls.Add(this.FE7Radio);
            this.gameGroupBox.Location = new System.Drawing.Point(177, 136);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(82, 82);
            this.gameGroupBox.TabIndex = 16;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Game";
            // 
            // paletteEntriesGroupBox
            // 
            this.paletteEntriesGroupBox.Controls.Add(this.insertEntryButton);
            this.paletteEntriesGroupBox.Controls.Add(this.autoExtractCheckBox);
            this.paletteEntriesGroupBox.Controls.Add(this.extractEntryButton);
            this.paletteEntriesGroupBox.Controls.Add(this.PaletteEntrySelector);
            this.paletteEntriesGroupBox.Enabled = false;
            this.paletteEntriesGroupBox.Location = new System.Drawing.Point(285, 124);
            this.paletteEntriesGroupBox.Name = "paletteEntriesGroupBox";
            this.paletteEntriesGroupBox.Size = new System.Drawing.Size(277, 103);
            this.paletteEntriesGroupBox.TabIndex = 17;
            this.paletteEntriesGroupBox.TabStop = false;
            this.paletteEntriesGroupBox.Text = "Palette entry";
            // 
            // insertEntryButton
            // 
            this.insertEntryButton.AutoSize = true;
            this.insertEntryButton.Location = new System.Drawing.Point(164, 45);
            this.insertEntryButton.Name = "insertEntryButton";
            this.insertEntryButton.Size = new System.Drawing.Size(104, 23);
            this.insertEntryButton.TabIndex = 14;
            this.insertEntryButton.Text = "Insert palette entry";
            this.insertEntryButton.UseVisualStyleBackColor = true;
            this.insertEntryButton.Click += new System.EventHandler(this.InsertEntryButton_Click);
            // 
            // autoExtractCheckBox
            // 
            this.autoExtractCheckBox.AutoSize = true;
            this.autoExtractCheckBox.Location = new System.Drawing.Point(8, 78);
            this.autoExtractCheckBox.Name = "autoExtractCheckBox";
            this.autoExtractCheckBox.Size = new System.Drawing.Size(81, 17);
            this.autoExtractCheckBox.TabIndex = 13;
            this.autoExtractCheckBox.Text = "AutoExtract";
            this.autoExtractCheckBox.UseVisualStyleBackColor = true;
            this.autoExtractCheckBox.CheckedChanged += new System.EventHandler(this.AutoExtractCheckBox_CheckedChanged);
            // 
            // mTabControl
            // 
            this.mTabControl.Controls.Add(this.ImportedTab);
            this.mTabControl.Controls.Add(this.ExtractedTab);
            this.mTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mTabControl.Location = new System.Drawing.Point(0, 249);
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(594, 163);
            this.mTabControl.TabIndex = 18;
            this.mTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // ImportedTab
            // 
            this.ImportedTab.Controls.Add(this.PalettesTabControl);
            this.ImportedTab.Location = new System.Drawing.Point(4, 22);
            this.ImportedTab.Name = "ImportedTab";
            this.ImportedTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportedTab.Size = new System.Drawing.Size(586, 137);
            this.ImportedTab.TabIndex = 0;
            this.ImportedTab.Text = "Imported palette";
            this.ImportedTab.UseVisualStyleBackColor = true;
            // 
            // ExtractedTab
            // 
            this.ExtractedTab.Controls.Add(this.extractedPaletteTabControl);
            this.ExtractedTab.Location = new System.Drawing.Point(4, 22);
            this.ExtractedTab.Name = "ExtractedTab";
            this.ExtractedTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExtractedTab.Size = new System.Drawing.Size(586, 137);
            this.ExtractedTab.TabIndex = 1;
            this.ExtractedTab.Text = "Extracted palette";
            this.ExtractedTab.UseVisualStyleBackColor = true;
            // 
            // extractedPaletteTabControl
            // 
            this.extractedPaletteTabControl.Controls.Add(this.extractedPlayerTab);
            this.extractedPaletteTabControl.Controls.Add(this.extractedEnemyTab);
            this.extractedPaletteTabControl.Controls.Add(this.extractedNpcTab);
            this.extractedPaletteTabControl.Controls.Add(this.extractedPlayer4LATab);
            this.extractedPaletteTabControl.Controls.Add(this.extractedPlayer1LATab);
            this.extractedPaletteTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractedPaletteTabControl.Location = new System.Drawing.Point(3, 3);
            this.extractedPaletteTabControl.Name = "extractedPaletteTabControl";
            this.extractedPaletteTabControl.SelectedIndex = 0;
            this.extractedPaletteTabControl.Size = new System.Drawing.Size(580, 131);
            this.extractedPaletteTabControl.TabIndex = 2;
            // 
            // extractedPlayerTab
            // 
            this.extractedPlayerTab.Controls.Add(this.extractedPlayerVisu);
            this.extractedPlayerTab.Location = new System.Drawing.Point(4, 22);
            this.extractedPlayerTab.Name = "extractedPlayerTab";
            this.extractedPlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.extractedPlayerTab.Size = new System.Drawing.Size(572, 105);
            this.extractedPlayerTab.TabIndex = 0;
            this.extractedPlayerTab.Text = "Player";
            this.extractedPlayerTab.UseVisualStyleBackColor = true;
            // 
            // extractedPlayerVisu
            // 
            this.extractedPlayerVisu.ColorsLoaded = false;
            this.extractedPlayerVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractedPlayerVisu.Location = new System.Drawing.Point(3, 3);
            this.extractedPlayerVisu.Name = "extractedPlayerVisu";
            this.extractedPlayerVisu.Size = new System.Drawing.Size(566, 99);
            this.extractedPlayerVisu.TabIndex = 0;
            // 
            // extractedEnemyTab
            // 
            this.extractedEnemyTab.Controls.Add(this.extractedEnemyVisu);
            this.extractedEnemyTab.Location = new System.Drawing.Point(4, 22);
            this.extractedEnemyTab.Name = "extractedEnemyTab";
            this.extractedEnemyTab.Padding = new System.Windows.Forms.Padding(3);
            this.extractedEnemyTab.Size = new System.Drawing.Size(572, 105);
            this.extractedEnemyTab.TabIndex = 1;
            this.extractedEnemyTab.Text = "Enemy";
            this.extractedEnemyTab.UseVisualStyleBackColor = true;
            // 
            // extractedEnemyVisu
            // 
            this.extractedEnemyVisu.ColorsLoaded = false;
            this.extractedEnemyVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractedEnemyVisu.Location = new System.Drawing.Point(3, 3);
            this.extractedEnemyVisu.Name = "extractedEnemyVisu";
            this.extractedEnemyVisu.Size = new System.Drawing.Size(566, 99);
            this.extractedEnemyVisu.TabIndex = 0;
            // 
            // extractedNpcTab
            // 
            this.extractedNpcTab.Controls.Add(this.extractedNpcVisu);
            this.extractedNpcTab.Location = new System.Drawing.Point(4, 22);
            this.extractedNpcTab.Name = "extractedNpcTab";
            this.extractedNpcTab.Padding = new System.Windows.Forms.Padding(3);
            this.extractedNpcTab.Size = new System.Drawing.Size(572, 105);
            this.extractedNpcTab.TabIndex = 2;
            this.extractedNpcTab.Text = "NPC";
            this.extractedNpcTab.UseVisualStyleBackColor = true;
            // 
            // extractedNpcVisu
            // 
            this.extractedNpcVisu.ColorsLoaded = false;
            this.extractedNpcVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractedNpcVisu.Location = new System.Drawing.Point(3, 3);
            this.extractedNpcVisu.Name = "extractedNpcVisu";
            this.extractedNpcVisu.Size = new System.Drawing.Size(566, 99);
            this.extractedNpcVisu.TabIndex = 0;
            // 
            // extractedPlayer4LATab
            // 
            this.extractedPlayer4LATab.Controls.Add(this.extractedPlayer4LAVisu);
            this.extractedPlayer4LATab.Location = new System.Drawing.Point(4, 22);
            this.extractedPlayer4LATab.Name = "extractedPlayer4LATab";
            this.extractedPlayer4LATab.Padding = new System.Windows.Forms.Padding(3);
            this.extractedPlayer4LATab.Size = new System.Drawing.Size(572, 105);
            this.extractedPlayer4LATab.TabIndex = 3;
            this.extractedPlayer4LATab.Text = "Player4 link arena";
            this.extractedPlayer4LATab.UseVisualStyleBackColor = true;
            // 
            // extractedPlayer4LAVisu
            // 
            this.extractedPlayer4LAVisu.ColorsLoaded = false;
            this.extractedPlayer4LAVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractedPlayer4LAVisu.Location = new System.Drawing.Point(3, 3);
            this.extractedPlayer4LAVisu.Name = "extractedPlayer4LAVisu";
            this.extractedPlayer4LAVisu.Size = new System.Drawing.Size(566, 99);
            this.extractedPlayer4LAVisu.TabIndex = 0;
            // 
            // extractedPlayer1LATab
            // 
            this.extractedPlayer1LATab.Controls.Add(this.extractedPlayer1LAVisu);
            this.extractedPlayer1LATab.Location = new System.Drawing.Point(4, 22);
            this.extractedPlayer1LATab.Name = "extractedPlayer1LATab";
            this.extractedPlayer1LATab.Padding = new System.Windows.Forms.Padding(3);
            this.extractedPlayer1LATab.Size = new System.Drawing.Size(572, 105);
            this.extractedPlayer1LATab.TabIndex = 4;
            this.extractedPlayer1LATab.Text = "Player1 link arena";
            this.extractedPlayer1LATab.UseVisualStyleBackColor = true;
            // 
            // extractedPlayer1LAVisu
            // 
            this.extractedPlayer1LAVisu.ColorsLoaded = false;
            this.extractedPlayer1LAVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extractedPlayer1LAVisu.Location = new System.Drawing.Point(3, 3);
            this.extractedPlayer1LAVisu.Name = "extractedPlayer1LAVisu";
            this.extractedPlayer1LAVisu.Size = new System.Drawing.Size(566, 99);
            this.extractedPlayer1LAVisu.TabIndex = 0;
            // 
            // BSPaletteAssemblerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 412);
            this.Controls.Add(this.mTabControl);
            this.Controls.Add(this.paletteEntriesGroupBox);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.defaultPaletteBox);
            this.Controls.Add(this.ResetGroupBox);
            this.Controls.Add(this.ClipboardGroupBox);
            this.Controls.Add(this.OutputFileGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 350);
            this.Name = "BSPaletteAssemblerForm";
            this.Text = "FE BSPalette Assembler";
            this.PalettesTabControl.ResumeLayout(false);
            this.PlayerPaletteTab.ResumeLayout(false);
            this.EnemyPaletteTab.ResumeLayout(false);
            this.NPCPaletteTab.ResumeLayout(false);
            this.Player4PaletteTab.ResumeLayout(false);
            this.Player1PaletteTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OffsetSelector)).EndInit();
            this.OutputFileGroupBox.ResumeLayout(false);
            this.OutputFileGroupBox.PerformLayout();
            this.ClipboardGroupBox.ResumeLayout(false);
            this.ResetGroupBox.ResumeLayout(false);
            this.defaultPaletteBox.ResumeLayout(false);
            this.defaultPaletteBox.PerformLayout();
            this.gameGroupBox.ResumeLayout(false);
            this.gameGroupBox.PerformLayout();
            this.paletteEntriesGroupBox.ResumeLayout(false);
            this.paletteEntriesGroupBox.PerformLayout();
            this.mTabControl.ResumeLayout(false);
            this.ImportedTab.ResumeLayout(false);
            this.ExtractedTab.ResumeLayout(false);
            this.extractedPaletteTabControl.ResumeLayout(false);
            this.extractedPlayerTab.ResumeLayout(false);
            this.extractedEnemyTab.ResumeLayout(false);
            this.extractedNpcTab.ResumeLayout(false);
            this.extractedPlayer4LATab.ResumeLayout(false);
            this.extractedPlayer1LATab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PalettesTabControl;
        private System.Windows.Forms.TabPage PlayerPaletteTab;
        private System.Windows.Forms.TabPage EnemyPaletteTab;
        private System.Windows.Forms.TabPage NPCPaletteTab;
        private System.Windows.Forms.TabPage Player4PaletteTab;
        private BSPaletteVisualizer PlayerPaletteVisualizer;
        private BSPaletteVisualizer EnemyPaletteVisualizer;
        private BSPaletteVisualizer NPCPaletteVisualizer;
        private BSPaletteVisualizer Player4PaletteVisualizer;
        private System.Windows.Forms.Button ClipboardImporter;
        private System.Windows.Forms.Button ClipboardExporter;
        private System.Windows.Forms.Button FileSaver;
        private System.Windows.Forms.NumericUpDown OffsetSelector;
        private System.Windows.Forms.TabPage Player1PaletteTab;
        private BSPaletteVisualizer Player1PaletteVisualizer;
        private System.Windows.Forms.Button ResetCurrentPalette;
        private System.Windows.Forms.Button ResetAll;
        private System.Windows.Forms.Label OffsetLabel;
        private System.Windows.Forms.GroupBox OutputFileGroupBox;
        private System.Windows.Forms.Button GetOutputFile;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.GroupBox ClipboardGroupBox;
        private System.Windows.Forms.GroupBox ResetGroupBox;
        private System.Windows.Forms.GroupBox defaultPaletteBox;
        private System.Windows.Forms.Button defaultPaletteButton;
        private System.Windows.Forms.Label currentDefaultPaletteNameLabel;
        private System.Windows.Forms.Label currentDefaultTextLabel;
        private System.Windows.Forms.CheckBox IsAROMCkBx;
        private System.Windows.Forms.ComboBox PaletteEntrySelector;
        private System.Windows.Forms.RadioButton FE6Radio;
        private System.Windows.Forms.RadioButton FE7Radio;
        private System.Windows.Forms.RadioButton FE8Radio;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.GroupBox paletteEntriesGroupBox;
        private System.Windows.Forms.Button extractEntryButton;
        private System.Windows.Forms.TabControl mTabControl;
        private System.Windows.Forms.TabPage ImportedTab;
        private System.Windows.Forms.TabPage ExtractedTab;
        private System.Windows.Forms.TabControl extractedPaletteTabControl;
        private System.Windows.Forms.TabPage extractedPlayerTab;
        private BSPaletteVisualizer extractedPlayerVisu;
        private System.Windows.Forms.TabPage extractedEnemyTab;
        private BSPaletteVisualizer extractedEnemyVisu;
        private System.Windows.Forms.TabPage extractedNpcTab;
        private BSPaletteVisualizer extractedNpcVisu;
        private System.Windows.Forms.TabPage extractedPlayer4LATab;
        private BSPaletteVisualizer extractedPlayer4LAVisu;
        private System.Windows.Forms.TabPage extractedPlayer1LATab;
        private BSPaletteVisualizer extractedPlayer1LAVisu;
        private System.Windows.Forms.CheckBox autoExtractCheckBox;
        private System.Windows.Forms.Button SaveROMButton;
        private System.Windows.Forms.Button insertEntryButton;
        private System.Windows.Forms.Button exportExtractedIndexButton;
    }
}

