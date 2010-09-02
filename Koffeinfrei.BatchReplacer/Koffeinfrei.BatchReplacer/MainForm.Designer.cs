namespace Koffeinfrei.BatchReplacer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.selectFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridRules = new System.Windows.Forms.DataGridView();
            this.searchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxRules = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxInputFiles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelectFiles = new System.Windows.Forms.Button();
            this.buttonSelectDir = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxOutputDir = new System.Windows.Forms.TextBox();
            this.labelOutputDir = new System.Windows.Forms.Label();
            this.labelAbsoluteOutputDir = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRulesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRulesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFoldersDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.importRulesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportRulesSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            this.groupBoxRules.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFilesDialog
            // 
            this.selectFilesDialog.FileName = "openFileDialog";
            this.selectFilesDialog.Multiselect = true;
            // 
            // dataGridRules
            // 
            this.dataGridRules.AutoGenerateColumns = false;
            this.dataGridRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchDataGridViewTextBoxColumn,
            this.replaceDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn});
            this.dataGridRules.DataSource = this.rulesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRules.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRules.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridRules.Location = new System.Drawing.Point(3, 16);
            this.dataGridRules.Name = "dataGridRules";
            this.dataGridRules.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridRules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRules.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRules.Size = new System.Drawing.Size(658, 176);
            this.dataGridRules.TabIndex = 2;
            // 
            // searchDataGridViewTextBoxColumn
            // 
            this.searchDataGridViewTextBoxColumn.DataPropertyName = "Search";
            this.searchDataGridViewTextBoxColumn.HeaderText = "Search";
            this.searchDataGridViewTextBoxColumn.Name = "searchDataGridViewTextBoxColumn";
            // 
            // replaceDataGridViewTextBoxColumn
            // 
            this.replaceDataGridViewTextBoxColumn.DataPropertyName = "Replace";
            this.replaceDataGridViewTextBoxColumn.HeaderText = "Replace";
            this.replaceDataGridViewTextBoxColumn.Name = "replaceDataGridViewTextBoxColumn";
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rulesBindingSource
            // 
            this.rulesBindingSource.DataSource = typeof(Koffeinfrei.BatchReplacer.Rules);
            // 
            // groupBoxRules
            // 
            this.groupBoxRules.Controls.Add(this.dataGridRules);
            this.groupBoxRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRules.Location = new System.Drawing.Point(3, 28);
            this.groupBoxRules.Name = "groupBoxRules";
            this.groupBoxRules.Size = new System.Drawing.Size(664, 195);
            this.groupBoxRules.TabIndex = 3;
            this.groupBoxRules.TabStop = false;
            this.groupBoxRules.Text = "Rules";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxRules, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonReplace, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFiles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mainMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Image = global::Koffeinfrei.BatchReplacer.Properties.Resources.replace;
            this.buttonReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReplace.Location = new System.Drawing.Point(3, 430);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 0;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonReplace, "Start the replace job");
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiles.Location = new System.Drawing.Point(3, 229);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(664, 195);
            this.groupBoxFiles.TabIndex = 4;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.10638F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxInputFiles, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.32692F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.67308F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(658, 176);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listBoxInputFiles
            // 
            this.listBoxInputFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInputFiles.FormattingEnabled = true;
            this.listBoxInputFiles.Location = new System.Drawing.Point(3, 3);
            this.listBoxInputFiles.Name = "listBoxInputFiles";
            this.listBoxInputFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxInputFiles.Size = new System.Drawing.Size(553, 133);
            this.listBoxInputFiles.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonSelectFiles, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonSelectDir, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(562, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(93, 133);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonSelectFiles
            // 
            this.buttonSelectFiles.Image = global::Koffeinfrei.BatchReplacer.Properties.Resources.files;
            this.buttonSelectFiles.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectFiles.MinimumSize = new System.Drawing.Size(28, 28);
            this.buttonSelectFiles.Name = "buttonSelectFiles";
            this.buttonSelectFiles.Size = new System.Drawing.Size(28, 28);
            this.buttonSelectFiles.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonSelectFiles, "Select files");
            this.buttonSelectFiles.UseVisualStyleBackColor = true;
            this.buttonSelectFiles.Click += new System.EventHandler(this.buttonSelectFiles_Click);
            // 
            // buttonSelectDir
            // 
            this.buttonSelectDir.Image = global::Koffeinfrei.BatchReplacer.Properties.Resources.folder;
            this.buttonSelectDir.Location = new System.Drawing.Point(3, 36);
            this.buttonSelectDir.Name = "buttonSelectDir";
            this.buttonSelectDir.Size = new System.Drawing.Size(28, 28);
            this.buttonSelectDir.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonSelectDir, "Select folder");
            this.buttonSelectDir.UseVisualStyleBackColor = true;
            this.buttonSelectDir.Click += new System.EventHandler(this.buttonSelectDir_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel4.Controls.Add(this.textBoxOutputDir, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelOutputDir, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelAbsoluteOutputDir, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 142);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(553, 31);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // textBoxOutputDir
            // 
            this.textBoxOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutputDir.Location = new System.Drawing.Point(120, 6);
            this.textBoxOutputDir.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBoxOutputDir.Name = "textBoxOutputDir";
            this.textBoxOutputDir.Size = new System.Drawing.Size(58, 20);
            this.textBoxOutputDir.TabIndex = 0;
            this.textBoxOutputDir.Text = "out";
            this.textBoxOutputDir.TextChanged += new System.EventHandler(this.textBoxOutputDir_TextChanged);
            this.textBoxOutputDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOutputDir_KeyPress);
            // 
            // labelOutputDir
            // 
            this.labelOutputDir.AutoSize = true;
            this.labelOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOutputDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOutputDir.Location = new System.Drawing.Point(3, 0);
            this.labelOutputDir.Name = "labelOutputDir";
            this.labelOutputDir.Size = new System.Drawing.Size(111, 31);
            this.labelOutputDir.TabIndex = 1;
            this.labelOutputDir.Text = "Output directory";
            this.labelOutputDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAbsoluteOutputDir
            // 
            this.labelAbsoluteOutputDir.AutoSize = true;
            this.labelAbsoluteOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAbsoluteOutputDir.Location = new System.Drawing.Point(184, 0);
            this.labelAbsoluteOutputDir.Name = "labelAbsoluteOutputDir";
            this.labelAbsoluteOutputDir.Size = new System.Drawing.Size(366, 31);
            this.labelAbsoluteOutputDir.TabIndex = 2;
            this.labelAbsoluteOutputDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 478);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(670, 20);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(624, 15);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 461);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(664, 14);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(670, 24);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importRulesMenuItem,
            this.exportRulesMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importRulesMenuItem
            // 
            this.importRulesMenuItem.Image = global::Koffeinfrei.BatchReplacer.Properties.Resources.import;
            this.importRulesMenuItem.Name = "importRulesMenuItem";
            this.importRulesMenuItem.Size = new System.Drawing.Size(138, 22);
            this.importRulesMenuItem.Text = "Import rules";
            this.importRulesMenuItem.Click += new System.EventHandler(this.importRulesMenuItem_Click);
            // 
            // exportRulesMenuItem
            // 
            this.exportRulesMenuItem.Image = global::Koffeinfrei.BatchReplacer.Properties.Resources.export;
            this.exportRulesMenuItem.Name = "exportRulesMenuItem";
            this.exportRulesMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exportRulesMenuItem.Text = "Export rules";
            this.exportRulesMenuItem.Click += new System.EventHandler(this.exportRulesMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::Koffeinfrei.BatchReplacer.Properties.Resources.exit;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Koffeinfrei.BatchReplacer.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // importRulesFileDialog
            // 
            this.importRulesFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Koffeinfrei Batch Replacer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            this.groupBoxRules.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog selectFilesDialog;
        private System.Windows.Forms.BindingSource rulesBindingSource;
        private System.Windows.Forms.DataGridView dataGridRules;
        private System.Windows.Forms.GroupBox groupBoxRules;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxOutputDir;
        private System.Windows.Forms.ListBox listBoxInputFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonSelectFiles;
        private System.Windows.Forms.Button buttonSelectDir;
        private System.Windows.Forms.FolderBrowserDialog selectFoldersDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.OpenFileDialog importRulesFileDialog;
        private System.Windows.Forms.SaveFileDialog exportRulesSaveFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelOutputDir;
        private System.Windows.Forms.Label labelAbsoluteOutputDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importRulesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRulesMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

