namespace ReferenceStyle
{
    partial class BookForm
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
            this.gbAddAuthors = new System.Windows.Forms.GroupBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.txtListOfAuthors = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lbListOfAuthors = new System.Windows.Forms.Label();
            this.lbLast = new System.Windows.Forms.Label();
            this.lbMiddle = new System.Windows.Forms.Label();
            this.lbFirst = new System.Windows.Forms.Label();
            this.lbAddAuthors = new System.Windows.Forms.Label();
            this.gbAddBookInformation = new System.Windows.Forms.GroupBox();
            this.txtPublisherCountry = new System.Windows.Forms.TextBox();
            this.txtPublisherState = new System.Windows.Forms.TextBox();
            this.txtPublisherCity = new System.Windows.Forms.TextBox();
            this.txtPubDateYear = new System.Windows.Forms.TextBox();
            this.txtPubDateDay = new System.Windows.Forms.TextBox();
            this.txtPubDateMonth = new System.Windows.Forms.TextBox();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lbCCYY = new System.Windows.Forms.Label();
            this.lbDD = new System.Windows.Forms.Label();
            this.lbMM = new System.Windows.Forms.Label();
            this.lbPublisherCountry = new System.Windows.Forms.Label();
            this.lbPublisherState = new System.Windows.Forms.Label();
            this.lbPublisherCity = new System.Windows.Forms.Label();
            this.lbPublicationDate = new System.Windows.Forms.Label();
            this.lbBookPublisher = new System.Windows.Forms.Label();
            this.lbBookTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbViewReferenceStyles = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnToManageReferences = new System.Windows.Forms.Button();
            this.btnAddAnotherBook = new System.Windows.Forms.Button();
            this.txtViewReferenceStyles = new System.Windows.Forms.TextBox();
            this.btnLibMedStyle = new System.Windows.Forms.Button();
            this.btnAPAStyle = new System.Windows.Forms.Button();
            this.btnMLAStyle = new System.Windows.Forms.Button();
            this.lbViewReferenceStyles = new System.Windows.Forms.Label();
            this.btnAddtoReferenceList = new System.Windows.Forms.Button();
            this.gbAddAuthors.SuspendLayout();
            this.gbAddBookInformation.SuspendLayout();
            this.gbViewReferenceStyles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddAuthors
            // 
            this.gbAddAuthors.Controls.Add(this.btnAddName);
            this.gbAddAuthors.Controls.Add(this.txtListOfAuthors);
            this.gbAddAuthors.Controls.Add(this.txtLast);
            this.gbAddAuthors.Controls.Add(this.txtMI);
            this.gbAddAuthors.Controls.Add(this.txtFirst);
            this.gbAddAuthors.Controls.Add(this.lbListOfAuthors);
            this.gbAddAuthors.Controls.Add(this.lbLast);
            this.gbAddAuthors.Controls.Add(this.lbMiddle);
            this.gbAddAuthors.Controls.Add(this.lbFirst);
            this.gbAddAuthors.Controls.Add(this.lbAddAuthors);
            this.gbAddAuthors.Location = new System.Drawing.Point(0, 0);
            this.gbAddAuthors.Name = "gbAddAuthors";
            this.gbAddAuthors.Size = new System.Drawing.Size(770, 129);
            this.gbAddAuthors.TabIndex = 0;
            this.gbAddAuthors.TabStop = false;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(421, 62);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 3;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // txtListOfAuthors
            // 
            this.txtListOfAuthors.Location = new System.Drawing.Point(502, 26);
            this.txtListOfAuthors.Multiline = true;
            this.txtListOfAuthors.Name = "txtListOfAuthors";
            this.txtListOfAuthors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListOfAuthors.Size = new System.Drawing.Size(251, 96);
            this.txtListOfAuthors.TabIndex = 8;
            this.txtListOfAuthors.TabStop = false;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(229, 78);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(161, 20);
            this.txtLast.TabIndex = 2;
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(188, 78);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(35, 20);
            this.txtMI.TabIndex = 1;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(50, 78);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(132, 20);
            this.txtFirst.TabIndex = 0;
            // 
            // lbListOfAuthors
            // 
            this.lbListOfAuthors.AutoSize = true;
            this.lbListOfAuthors.Location = new System.Drawing.Point(594, 10);
            this.lbListOfAuthors.Name = "lbListOfAuthors";
            this.lbListOfAuthors.Size = new System.Drawing.Size(74, 13);
            this.lbListOfAuthors.TabIndex = 4;
            this.lbListOfAuthors.Text = "List of Authors";
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Location = new System.Drawing.Point(274, 62);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(27, 13);
            this.lbLast.TabIndex = 3;
            this.lbLast.Text = "Last";
            // 
            // lbMiddle
            // 
            this.lbMiddle.AutoSize = true;
            this.lbMiddle.Location = new System.Drawing.Point(197, 62);
            this.lbMiddle.Name = "lbMiddle";
            this.lbMiddle.Size = new System.Drawing.Size(19, 13);
            this.lbMiddle.TabIndex = 2;
            this.lbMiddle.Text = "MI";
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Location = new System.Drawing.Point(47, 62);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(26, 13);
            this.lbFirst.TabIndex = 1;
            this.lbFirst.Text = "First";
            // 
            // lbAddAuthors
            // 
            this.lbAddAuthors.AutoSize = true;
            this.lbAddAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddAuthors.Location = new System.Drawing.Point(5, 10);
            this.lbAddAuthors.Name = "lbAddAuthors";
            this.lbAddAuthors.Size = new System.Drawing.Size(126, 24);
            this.lbAddAuthors.TabIndex = 0;
            this.lbAddAuthors.Text = "Add Authors";
            // 
            // gbAddBookInformation
            // 
            this.gbAddBookInformation.Controls.Add(this.txtPublisherCountry);
            this.gbAddBookInformation.Controls.Add(this.txtPublisherState);
            this.gbAddBookInformation.Controls.Add(this.txtPublisherCity);
            this.gbAddBookInformation.Controls.Add(this.txtPubDateYear);
            this.gbAddBookInformation.Controls.Add(this.txtPubDateDay);
            this.gbAddBookInformation.Controls.Add(this.txtPubDateMonth);
            this.gbAddBookInformation.Controls.Add(this.txtBookPublisher);
            this.gbAddBookInformation.Controls.Add(this.txtBookTitle);
            this.gbAddBookInformation.Controls.Add(this.btnAddBook);
            this.gbAddBookInformation.Controls.Add(this.lbCCYY);
            this.gbAddBookInformation.Controls.Add(this.lbDD);
            this.gbAddBookInformation.Controls.Add(this.lbMM);
            this.gbAddBookInformation.Controls.Add(this.lbPublisherCountry);
            this.gbAddBookInformation.Controls.Add(this.lbPublisherState);
            this.gbAddBookInformation.Controls.Add(this.lbPublisherCity);
            this.gbAddBookInformation.Controls.Add(this.lbPublicationDate);
            this.gbAddBookInformation.Controls.Add(this.lbBookPublisher);
            this.gbAddBookInformation.Controls.Add(this.lbBookTitle);
            this.gbAddBookInformation.Controls.Add(this.label1);
            this.gbAddBookInformation.Location = new System.Drawing.Point(0, 135);
            this.gbAddBookInformation.Name = "gbAddBookInformation";
            this.gbAddBookInformation.Size = new System.Drawing.Size(770, 255);
            this.gbAddBookInformation.TabIndex = 1;
            this.gbAddBookInformation.TabStop = false;
            // 
            // txtPublisherCountry
            // 
            this.txtPublisherCountry.Location = new System.Drawing.Point(160, 189);
            this.txtPublisherCountry.Name = "txtPublisherCountry";
            this.txtPublisherCountry.Size = new System.Drawing.Size(100, 20);
            this.txtPublisherCountry.TabIndex = 7;
            // 
            // txtPublisherState
            // 
            this.txtPublisherState.Location = new System.Drawing.Point(160, 163);
            this.txtPublisherState.Name = "txtPublisherState";
            this.txtPublisherState.Size = new System.Drawing.Size(37, 20);
            this.txtPublisherState.TabIndex = 6;
            // 
            // txtPublisherCity
            // 
            this.txtPublisherCity.Location = new System.Drawing.Point(160, 137);
            this.txtPublisherCity.Name = "txtPublisherCity";
            this.txtPublisherCity.Size = new System.Drawing.Size(230, 20);
            this.txtPublisherCity.TabIndex = 5;
            // 
            // txtPubDateYear
            // 
            this.txtPubDateYear.Location = new System.Drawing.Point(277, 111);
            this.txtPubDateYear.Name = "txtPubDateYear";
            this.txtPubDateYear.Size = new System.Drawing.Size(50, 20);
            this.txtPubDateYear.TabIndex = 4;
            // 
            // txtPubDateDay
            // 
            this.txtPubDateDay.Location = new System.Drawing.Point(218, 111);
            this.txtPubDateDay.Name = "txtPubDateDay";
            this.txtPubDateDay.Size = new System.Drawing.Size(31, 20);
            this.txtPubDateDay.TabIndex = 3;
            // 
            // txtPubDateMonth
            // 
            this.txtPubDateMonth.Location = new System.Drawing.Point(160, 111);
            this.txtPubDateMonth.Name = "txtPubDateMonth";
            this.txtPubDateMonth.Size = new System.Drawing.Size(37, 20);
            this.txtPubDateMonth.TabIndex = 2;
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Location = new System.Drawing.Point(160, 72);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(230, 20);
            this.txtBookPublisher.TabIndex = 1;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(160, 46);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(454, 20);
            this.txtBookTitle.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(23, 220);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lbCCYY
            // 
            this.lbCCYY.AutoSize = true;
            this.lbCCYY.Location = new System.Drawing.Point(283, 95);
            this.lbCCYY.Name = "lbCCYY";
            this.lbCCYY.Size = new System.Drawing.Size(35, 13);
            this.lbCCYY.TabIndex = 9;
            this.lbCCYY.Text = "CCYY";
            // 
            // lbDD
            // 
            this.lbDD.AutoSize = true;
            this.lbDD.Location = new System.Drawing.Point(215, 95);
            this.lbDD.Name = "lbDD";
            this.lbDD.Size = new System.Drawing.Size(23, 13);
            this.lbDD.TabIndex = 8;
            this.lbDD.Text = "DD";
            // 
            // lbMM
            // 
            this.lbMM.AutoSize = true;
            this.lbMM.Location = new System.Drawing.Point(157, 95);
            this.lbMM.Name = "lbMM";
            this.lbMM.Size = new System.Drawing.Size(25, 13);
            this.lbMM.TabIndex = 7;
            this.lbMM.Text = "MM";
            // 
            // lbPublisherCountry
            // 
            this.lbPublisherCountry.AutoSize = true;
            this.lbPublisherCountry.Location = new System.Drawing.Point(20, 192);
            this.lbPublisherCountry.Name = "lbPublisherCountry";
            this.lbPublisherCountry.Size = new System.Drawing.Size(89, 13);
            this.lbPublisherCountry.TabIndex = 6;
            this.lbPublisherCountry.Text = "Publisher Country";
            // 
            // lbPublisherState
            // 
            this.lbPublisherState.AutoSize = true;
            this.lbPublisherState.Location = new System.Drawing.Point(20, 166);
            this.lbPublisherState.Name = "lbPublisherState";
            this.lbPublisherState.Size = new System.Drawing.Size(78, 13);
            this.lbPublisherState.TabIndex = 5;
            this.lbPublisherState.Text = "Publisher State";
            // 
            // lbPublisherCity
            // 
            this.lbPublisherCity.AutoSize = true;
            this.lbPublisherCity.Location = new System.Drawing.Point(20, 140);
            this.lbPublisherCity.Name = "lbPublisherCity";
            this.lbPublisherCity.Size = new System.Drawing.Size(70, 13);
            this.lbPublisherCity.TabIndex = 4;
            this.lbPublisherCity.Text = "Publisher City";
            // 
            // lbPublicationDate
            // 
            this.lbPublicationDate.AutoSize = true;
            this.lbPublicationDate.Location = new System.Drawing.Point(20, 114);
            this.lbPublicationDate.Name = "lbPublicationDate";
            this.lbPublicationDate.Size = new System.Drawing.Size(85, 13);
            this.lbPublicationDate.TabIndex = 3;
            this.lbPublicationDate.Text = "Publication Date";
            // 
            // lbBookPublisher
            // 
            this.lbBookPublisher.AutoSize = true;
            this.lbBookPublisher.Location = new System.Drawing.Point(20, 75);
            this.lbBookPublisher.Name = "lbBookPublisher";
            this.lbBookPublisher.Size = new System.Drawing.Size(78, 13);
            this.lbBookPublisher.TabIndex = 2;
            this.lbBookPublisher.Text = "Book Publisher";
            // 
            // lbBookTitle
            // 
            this.lbBookTitle.AutoSize = true;
            this.lbBookTitle.Location = new System.Drawing.Point(20, 49);
            this.lbBookTitle.Name = "lbBookTitle";
            this.lbBookTitle.Size = new System.Drawing.Size(55, 13);
            this.lbBookTitle.TabIndex = 1;
            this.lbBookTitle.Text = "Book Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Book Information";
            // 
            // gbViewReferenceStyles
            // 
            this.gbViewReferenceStyles.Controls.Add(this.btnExit);
            this.gbViewReferenceStyles.Controls.Add(this.btnReturnToManageReferences);
            this.gbViewReferenceStyles.Controls.Add(this.btnAddAnotherBook);
            this.gbViewReferenceStyles.Controls.Add(this.txtViewReferenceStyles);
            this.gbViewReferenceStyles.Controls.Add(this.btnLibMedStyle);
            this.gbViewReferenceStyles.Controls.Add(this.btnAPAStyle);
            this.gbViewReferenceStyles.Controls.Add(this.btnMLAStyle);
            this.gbViewReferenceStyles.Controls.Add(this.lbViewReferenceStyles);
            this.gbViewReferenceStyles.Location = new System.Drawing.Point(0, 396);
            this.gbViewReferenceStyles.Name = "gbViewReferenceStyles";
            this.gbViewReferenceStyles.Size = new System.Drawing.Size(770, 228);
            this.gbViewReferenceStyles.TabIndex = 2;
            this.gbViewReferenceStyles.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(502, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturnToManageReferences
            // 
            this.btnReturnToManageReferences.Location = new System.Drawing.Point(315, 198);
            this.btnReturnToManageReferences.Name = "btnReturnToManageReferences";
            this.btnReturnToManageReferences.Size = new System.Drawing.Size(181, 23);
            this.btnReturnToManageReferences.TabIndex = 4;
            this.btnReturnToManageReferences.Text = "Return To Manage References";
            this.btnReturnToManageReferences.UseVisualStyleBackColor = true;
            this.btnReturnToManageReferences.Click += new System.EventHandler(this.btnReturnToManageReferences_Click);
            // 
            // btnAddAnotherBook
            // 
            this.btnAddAnotherBook.Enabled = false;
            this.btnAddAnotherBook.Location = new System.Drawing.Point(160, 198);
            this.btnAddAnotherBook.Name = "btnAddAnotherBook";
            this.btnAddAnotherBook.Size = new System.Drawing.Size(149, 23);
            this.btnAddAnotherBook.TabIndex = 3;
            this.btnAddAnotherBook.Text = "Add Another Book";
            this.btnAddAnotherBook.UseVisualStyleBackColor = true;
            this.btnAddAnotherBook.Click += new System.EventHandler(this.btnAddAnotherBook_Click);
            // 
            // txtViewReferenceStyles
            // 
            this.txtViewReferenceStyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewReferenceStyles.Location = new System.Drawing.Point(160, 44);
            this.txtViewReferenceStyles.Multiline = true;
            this.txtViewReferenceStyles.Name = "txtViewReferenceStyles";
            this.txtViewReferenceStyles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtViewReferenceStyles.Size = new System.Drawing.Size(593, 148);
            this.txtViewReferenceStyles.TabIndex = 4;
            this.txtViewReferenceStyles.TabStop = false;
            // 
            // btnLibMedStyle
            // 
            this.btnLibMedStyle.Enabled = false;
            this.btnLibMedStyle.Location = new System.Drawing.Point(23, 169);
            this.btnLibMedStyle.Name = "btnLibMedStyle";
            this.btnLibMedStyle.Size = new System.Drawing.Size(75, 23);
            this.btnLibMedStyle.TabIndex = 2;
            this.btnLibMedStyle.Text = "LibMed Style";
            this.btnLibMedStyle.UseVisualStyleBackColor = true;
            this.btnLibMedStyle.Click += new System.EventHandler(this.btnLibMedStyle_Click);
            // 
            // btnAPAStyle
            // 
            this.btnAPAStyle.Enabled = false;
            this.btnAPAStyle.Location = new System.Drawing.Point(23, 100);
            this.btnAPAStyle.Name = "btnAPAStyle";
            this.btnAPAStyle.Size = new System.Drawing.Size(75, 23);
            this.btnAPAStyle.TabIndex = 1;
            this.btnAPAStyle.Text = "APA Style";
            this.btnAPAStyle.UseVisualStyleBackColor = true;
            this.btnAPAStyle.Click += new System.EventHandler(this.btnAPAStyle_Click);
            // 
            // btnMLAStyle
            // 
            this.btnMLAStyle.Enabled = false;
            this.btnMLAStyle.Location = new System.Drawing.Point(23, 44);
            this.btnMLAStyle.Name = "btnMLAStyle";
            this.btnMLAStyle.Size = new System.Drawing.Size(75, 23);
            this.btnMLAStyle.TabIndex = 0;
            this.btnMLAStyle.Text = "MLA Style";
            this.btnMLAStyle.UseVisualStyleBackColor = true;
            this.btnMLAStyle.Click += new System.EventHandler(this.btnMLAStyle_Click);
            // 
            // lbViewReferenceStyles
            // 
            this.lbViewReferenceStyles.AutoSize = true;
            this.lbViewReferenceStyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewReferenceStyles.Location = new System.Drawing.Point(6, 16);
            this.lbViewReferenceStyles.Name = "lbViewReferenceStyles";
            this.lbViewReferenceStyles.Size = new System.Drawing.Size(249, 25);
            this.lbViewReferenceStyles.TabIndex = 0;
            this.lbViewReferenceStyles.Text = "View Reference Styles";
            // 
            // btnAddtoReferenceList
            // 
            this.btnAddtoReferenceList.Location = new System.Drawing.Point(340, 623);
            this.btnAddtoReferenceList.Name = "btnAddtoReferenceList";
            this.btnAddtoReferenceList.Size = new System.Drawing.Size(124, 23);
            this.btnAddtoReferenceList.TabIndex = 3;
            this.btnAddtoReferenceList.Text = "Add to Reference List";
            this.btnAddtoReferenceList.UseVisualStyleBackColor = true;
            this.btnAddtoReferenceList.Click += new System.EventHandler(this.btnAddtoReferenceList_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 657);
            this.Controls.Add(this.btnAddtoReferenceList);
            this.Controls.Add(this.gbViewReferenceStyles);
            this.Controls.Add(this.gbAddBookInformation);
            this.Controls.Add(this.gbAddAuthors);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.gbAddAuthors.ResumeLayout(false);
            this.gbAddAuthors.PerformLayout();
            this.gbAddBookInformation.ResumeLayout(false);
            this.gbAddBookInformation.PerformLayout();
            this.gbViewReferenceStyles.ResumeLayout(false);
            this.gbViewReferenceStyles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddAuthors;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.TextBox txtListOfAuthors;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lbListOfAuthors;
        private System.Windows.Forms.Label lbLast;
        private System.Windows.Forms.Label lbMiddle;
        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.Label lbAddAuthors;
        private System.Windows.Forms.GroupBox gbAddBookInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPublisherCountry;
        private System.Windows.Forms.Label lbPublisherState;
        private System.Windows.Forms.Label lbPublisherCity;
        private System.Windows.Forms.Label lbPublicationDate;
        private System.Windows.Forms.Label lbBookPublisher;
        private System.Windows.Forms.Label lbBookTitle;
        private System.Windows.Forms.Label lbCCYY;
        private System.Windows.Forms.Label lbDD;
        private System.Windows.Forms.Label lbMM;
        private System.Windows.Forms.TextBox txtPublisherCountry;
        private System.Windows.Forms.TextBox txtPublisherState;
        private System.Windows.Forms.TextBox txtPublisherCity;
        private System.Windows.Forms.TextBox txtPubDateYear;
        private System.Windows.Forms.TextBox txtPubDateDay;
        private System.Windows.Forms.TextBox txtPubDateMonth;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox gbViewReferenceStyles;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnToManageReferences;
        private System.Windows.Forms.Button btnAddAnotherBook;
        private System.Windows.Forms.TextBox txtViewReferenceStyles;
        private System.Windows.Forms.Button btnLibMedStyle;
        private System.Windows.Forms.Button btnAPAStyle;
        private System.Windows.Forms.Button btnMLAStyle;
        private System.Windows.Forms.Label lbViewReferenceStyles;
        private System.Windows.Forms.Button btnAddtoReferenceList;
    }
}