namespace FileSafe
{
    partial class FrmFileIO
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSaveAllSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSaveSelFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDecryptSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDecryptAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEncryptSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEncryptAll = new System.Windows.Forms.ToolStripMenuItem();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEncrypt});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(404, 24);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemOpen,
            this.mnuItemSaveAll,
            this.mnuItemSaveAllSel,
            this.mnuItemSaveSelFileAs,
            this.mnuItemExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuItemOpen
            // 
            this.mnuItemOpen.Name = "mnuItemOpen";
            this.mnuItemOpen.Size = new System.Drawing.Size(182, 22);
            this.mnuItemOpen.Text = "Open";
            this.mnuItemOpen.Click += new System.EventHandler(this.MnuItemOpen_Click);
            // 
            // mnuItemSaveAll
            // 
            this.mnuItemSaveAll.Name = "mnuItemSaveAll";
            this.mnuItemSaveAll.Size = new System.Drawing.Size(182, 22);
            this.mnuItemSaveAll.Text = "Save All";
            this.mnuItemSaveAll.Click += new System.EventHandler(this.MnuItemSaveAll_Click);
            // 
            // mnuItemSaveAllSel
            // 
            this.mnuItemSaveAllSel.Name = "mnuItemSaveAllSel";
            this.mnuItemSaveAllSel.Size = new System.Drawing.Size(182, 22);
            this.mnuItemSaveAllSel.Text = "Save All Selected";
            this.mnuItemSaveAllSel.Click += new System.EventHandler(this.MnuItemSaveAllSel_Click);
            // 
            // mnuItemSaveSelFileAs
            // 
            this.mnuItemSaveSelFileAs.Name = "mnuItemSaveSelFileAs";
            this.mnuItemSaveSelFileAs.Size = new System.Drawing.Size(182, 22);
            this.mnuItemSaveSelFileAs.Text = "Save Selected File As";
            this.mnuItemSaveSelFileAs.Click += new System.EventHandler(this.MnuItemSaveSelFileAs_Click);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(182, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.MnuItemExit_Click);
            // 
            // mnuEncrypt
            // 
            this.mnuEncrypt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemDecryptSel,
            this.mnuItemDecryptAll,
            this.mnuItemEncryptSel,
            this.mnuItemEncryptAll});
            this.mnuEncrypt.Name = "mnuEncrypt";
            this.mnuEncrypt.Size = new System.Drawing.Size(76, 20);
            this.mnuEncrypt.Text = "Encryption";
            // 
            // mnuItemDecryptSel
            // 
            this.mnuItemDecryptSel.Name = "mnuItemDecryptSel";
            this.mnuItemDecryptSel.Size = new System.Drawing.Size(162, 22);
            this.mnuItemDecryptSel.Text = "Decrypt Selected";
            this.mnuItemDecryptSel.Click += new System.EventHandler(this.MnuItemDecryptSel_Click);
            // 
            // mnuItemDecryptAll
            // 
            this.mnuItemDecryptAll.Name = "mnuItemDecryptAll";
            this.mnuItemDecryptAll.Size = new System.Drawing.Size(162, 22);
            this.mnuItemDecryptAll.Text = "Decrypt All";
            this.mnuItemDecryptAll.Click += new System.EventHandler(this.MnuItemDecryptAll_Click);
            // 
            // mnuItemEncryptSel
            // 
            this.mnuItemEncryptSel.Name = "mnuItemEncryptSel";
            this.mnuItemEncryptSel.Size = new System.Drawing.Size(162, 22);
            this.mnuItemEncryptSel.Text = "Encrypt Selected";
            this.mnuItemEncryptSel.Click += new System.EventHandler(this.MnuItemEncryptSel_Click);
            // 
            // mnuItemEncryptAll
            // 
            this.mnuItemEncryptAll.Name = "mnuItemEncryptAll";
            this.mnuItemEncryptAll.Size = new System.Drawing.Size(162, 22);
            this.mnuItemEncryptAll.Text = "Encrypt All";
            this.mnuItemEncryptAll.Click += new System.EventHandler(this.MnuItemEncryptAll_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(39, 65);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(324, 108);
            this.lstFiles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Files:";
            // 
            // FrmFileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 208);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFiles);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "FrmFileIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileSafe";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOpen;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSaveAllSel;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSaveSelFileAs;
        private System.Windows.Forms.ToolStripMenuItem mnuEncrypt;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDecryptSel;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDecryptAll;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEncryptSel;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEncryptAll;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSaveAll;
    }
}

