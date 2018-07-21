namespace ReferenceStyle
{
    partial class ManageReferencesForm
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
            this.lbReferences = new System.Windows.Forms.Label();
            this.mnuSReferences = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRefrencesFromADataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRefrencesToADataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewRefrenceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printRefrencesToADocumentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printReferencesToAPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRefrenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnViewMLA = new System.Windows.Forms.RadioButton();
            this.rbtnViewAPA = new System.Windows.Forms.RadioButton();
            this.rbtnViewLibMed = new System.Windows.Forms.RadioButton();
            this.rtxtReferences = new System.Windows.Forms.RichTextBox();
            this.mnuSReferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbReferences
            // 
            this.lbReferences.AutoSize = true;
            this.lbReferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReferences.Location = new System.Drawing.Point(361, 72);
            this.lbReferences.Name = "lbReferences";
            this.lbReferences.Size = new System.Drawing.Size(132, 25);
            this.lbReferences.TabIndex = 0;
            this.lbReferences.Text = "References";
            // 
            // mnuSReferences
            // 
            this.mnuSReferences.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addRefrenceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuSReferences.Location = new System.Drawing.Point(0, 0);
            this.mnuSReferences.Name = "mnuSReferences";
            this.mnuSReferences.Size = new System.Drawing.Size(799, 24);
            this.mnuSReferences.TabIndex = 1;
            this.mnuSReferences.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRefrencesFromADataFileToolStripMenuItem,
            this.saveRefrencesToADataFileToolStripMenuItem,
            this.startNewRefrenceListToolStripMenuItem,
            this.printRefrencesToADocumentFileToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printReferencesToAPrinterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openRefrencesFromADataFileToolStripMenuItem
            // 
            this.openRefrencesFromADataFileToolStripMenuItem.Name = "openRefrencesFromADataFileToolStripMenuItem";
            this.openRefrencesFromADataFileToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.openRefrencesFromADataFileToolStripMenuItem.Text = "Open References From a Data File";
            this.openRefrencesFromADataFileToolStripMenuItem.Click += new System.EventHandler(this.openRefrencesFromADataFileToolStripMenuItem_Click);
            // 
            // saveRefrencesToADataFileToolStripMenuItem
            // 
            this.saveRefrencesToADataFileToolStripMenuItem.Name = "saveRefrencesToADataFileToolStripMenuItem";
            this.saveRefrencesToADataFileToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.saveRefrencesToADataFileToolStripMenuItem.Text = "Save References to a Data File";
            this.saveRefrencesToADataFileToolStripMenuItem.Click += new System.EventHandler(this.saveRefrencesToADataFileToolStripMenuItem_Click);
            // 
            // startNewRefrenceListToolStripMenuItem
            // 
            this.startNewRefrenceListToolStripMenuItem.Name = "startNewRefrenceListToolStripMenuItem";
            this.startNewRefrenceListToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.startNewRefrenceListToolStripMenuItem.Text = "Start New Reference List";
            this.startNewRefrenceListToolStripMenuItem.Click += new System.EventHandler(this.startNewRefrenceListToolStripMenuItem_Click);
            // 
            // printRefrencesToADocumentFileToolStripMenuItem
            // 
            this.printRefrencesToADocumentFileToolStripMenuItem.Name = "printRefrencesToADocumentFileToolStripMenuItem";
            this.printRefrencesToADocumentFileToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.printRefrencesToADocumentFileToolStripMenuItem.Text = "Print References to a Document File";
            this.printRefrencesToADocumentFileToolStripMenuItem.Click += new System.EventHandler(this.printRefrencesToADocumentFileToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printReferencesToAPrinterToolStripMenuItem
            // 
            this.printReferencesToAPrinterToolStripMenuItem.Name = "printReferencesToAPrinterToolStripMenuItem";
            this.printReferencesToAPrinterToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.printReferencesToAPrinterToolStripMenuItem.Text = "Print References to a Printer";
            this.printReferencesToAPrinterToolStripMenuItem.Click += new System.EventHandler(this.printReferencesToAPrinterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // addRefrenceToolStripMenuItem
            // 
            this.addRefrenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.chapterToolStripMenuItem,
            this.journalToolStripMenuItem});
            this.addRefrenceToolStripMenuItem.Name = "addRefrenceToolStripMenuItem";
            this.addRefrenceToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.addRefrenceToolStripMenuItem.Text = "Add Reference";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // chapterToolStripMenuItem
            // 
            this.chapterToolStripMenuItem.Name = "chapterToolStripMenuItem";
            this.chapterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.chapterToolStripMenuItem.Text = "Chapter";
            this.chapterToolStripMenuItem.Click += new System.EventHandler(this.chapterToolStripMenuItem_Click);
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.journalToolStripMenuItem.Text = "Journal";
            this.journalToolStripMenuItem.Click += new System.EventHandler(this.journalToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rbtnViewMLA
            // 
            this.rbtnViewMLA.AutoSize = true;
            this.rbtnViewMLA.Location = new System.Drawing.Point(12, 150);
            this.rbtnViewMLA.Name = "rbtnViewMLA";
            this.rbtnViewMLA.Size = new System.Drawing.Size(73, 17);
            this.rbtnViewMLA.TabIndex = 2;
            this.rbtnViewMLA.TabStop = true;
            this.rbtnViewMLA.Text = "View MLA";
            this.rbtnViewMLA.UseVisualStyleBackColor = true;
            this.rbtnViewMLA.CheckedChanged += new System.EventHandler(this.rbtnViewMLA_CheckedChanged);
            // 
            // rbtnViewAPA
            // 
            this.rbtnViewAPA.AutoSize = true;
            this.rbtnViewAPA.Location = new System.Drawing.Point(12, 229);
            this.rbtnViewAPA.Name = "rbtnViewAPA";
            this.rbtnViewAPA.Size = new System.Drawing.Size(72, 17);
            this.rbtnViewAPA.TabIndex = 3;
            this.rbtnViewAPA.TabStop = true;
            this.rbtnViewAPA.Text = "View APA";
            this.rbtnViewAPA.UseVisualStyleBackColor = true;
            // 
            // rbtnViewLibMed
            // 
            this.rbtnViewLibMed.AutoSize = true;
            this.rbtnViewLibMed.Location = new System.Drawing.Point(12, 298);
            this.rbtnViewLibMed.Name = "rbtnViewLibMed";
            this.rbtnViewLibMed.Size = new System.Drawing.Size(86, 17);
            this.rbtnViewLibMed.TabIndex = 4;
            this.rbtnViewLibMed.TabStop = true;
            this.rbtnViewLibMed.Text = "View LibMed";
            this.rbtnViewLibMed.UseVisualStyleBackColor = true;
            // 
            // rtxtReferences
            // 
            this.rtxtReferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtReferences.Location = new System.Drawing.Point(140, 100);
            this.rtxtReferences.Name = "rtxtReferences";
            this.rtxtReferences.Size = new System.Drawing.Size(587, 263);
            this.rtxtReferences.TabIndex = 5;
            this.rtxtReferences.TabStop = false;
            this.rtxtReferences.Text = "";
            // 
            // ManageReferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 401);
            this.Controls.Add(this.rtxtReferences);
            this.Controls.Add(this.rbtnViewLibMed);
            this.Controls.Add(this.rbtnViewAPA);
            this.Controls.Add(this.rbtnViewMLA);
            this.Controls.Add(this.lbReferences);
            this.Controls.Add(this.mnuSReferences);
            this.MainMenuStrip = this.mnuSReferences;
            this.Name = "ManageReferencesForm";
            this.Text = "ManageReferencesForm";
            this.mnuSReferences.ResumeLayout(false);
            this.mnuSReferences.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReferences;
        private System.Windows.Forms.MenuStrip mnuSReferences;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRefrencesFromADataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRefrencesToADataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewRefrenceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printRefrencesToADocumentFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printReferencesToAPrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRefrenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbtnViewMLA;
        private System.Windows.Forms.RadioButton rbtnViewAPA;
        private System.Windows.Forms.RadioButton rbtnViewLibMed;
        private System.Windows.Forms.RichTextBox rtxtReferences;
    }
}