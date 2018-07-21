namespace RefrenceStyle
{
    partial class nameSorter
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
            this.lbPageTitle = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbMiddleInitial = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.btnAddNameToList = new System.Windows.Forms.Button();
            this.btnClearForNextAuthor = new System.Windows.Forms.Button();
            this.lbOutputTextBox = new System.Windows.Forms.Label();
            this.txtNameSorterOutput = new System.Windows.Forms.TextBox();
            this.btnSortList = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPageTitle
            // 
            this.lbPageTitle.AutoSize = true;
            this.lbPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageTitle.Location = new System.Drawing.Point(50, 9);
            this.lbPageTitle.Name = "lbPageTitle";
            this.lbPageTitle.Size = new System.Drawing.Size(287, 24);
            this.lbPageTitle.TabIndex = 0;
            this.lbPageTitle.Text = "Create a List of Author Names";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 60);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First Name";
            // 
            // lbMiddleInitial
            // 
            this.lbMiddleInitial.AutoSize = true;
            this.lbMiddleInitial.Location = new System.Drawing.Point(12, 94);
            this.lbMiddleInitial.Name = "lbMiddleInitial";
            this.lbMiddleInitial.Size = new System.Drawing.Size(65, 13);
            this.lbMiddleInitial.TabIndex = 2;
            this.lbMiddleInitial.Text = "Middle Initial";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 131);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(55, 13);
            this.lbLastName.TabIndex = 3;
            this.lbLastName.Text = "LastName";
            // 
            // btnAddNameToList
            // 
            this.btnAddNameToList.Location = new System.Drawing.Point(15, 175);
            this.btnAddNameToList.Name = "btnAddNameToList";
            this.btnAddNameToList.Size = new System.Drawing.Size(106, 23);
            this.btnAddNameToList.TabIndex = 3;
            this.btnAddNameToList.Text = "Add Name to List";
            this.btnAddNameToList.UseVisualStyleBackColor = true;
            this.btnAddNameToList.Click += new System.EventHandler(this.btnAddNameToList_Click);
            // 
            // btnClearForNextAuthor
            // 
            this.btnClearForNextAuthor.Location = new System.Drawing.Point(15, 215);
            this.btnClearForNextAuthor.Name = "btnClearForNextAuthor";
            this.btnClearForNextAuthor.Size = new System.Drawing.Size(120, 23);
            this.btnClearForNextAuthor.TabIndex = 4;
            this.btnClearForNextAuthor.Text = "Clear for Next Author";
            this.btnClearForNextAuthor.UseVisualStyleBackColor = true;
            this.btnClearForNextAuthor.Click += new System.EventHandler(this.btnClearForNextAuthor_Click);
            // 
            // lbOutputTextBox
            // 
            this.lbOutputTextBox.AutoSize = true;
            this.lbOutputTextBox.Location = new System.Drawing.Point(241, 41);
            this.lbOutputTextBox.Name = "lbOutputTextBox";
            this.lbOutputTextBox.Size = new System.Drawing.Size(74, 13);
            this.lbOutputTextBox.TabIndex = 6;
            this.lbOutputTextBox.Text = "Author Names";
            // 
            // txtNameSorterOutput
            // 
            this.txtNameSorterOutput.Location = new System.Drawing.Point(187, 57);
            this.txtNameSorterOutput.Multiline = true;
            this.txtNameSorterOutput.Name = "txtNameSorterOutput";
            this.txtNameSorterOutput.ReadOnly = true;
            this.txtNameSorterOutput.Size = new System.Drawing.Size(182, 141);
            this.txtNameSorterOutput.TabIndex = 7;
            this.txtNameSorterOutput.TabStop = false;
            // 
            // btnSortList
            // 
            this.btnSortList.Location = new System.Drawing.Point(187, 215);
            this.btnSortList.Name = "btnSortList";
            this.btnSortList.Size = new System.Drawing.Size(75, 23);
            this.btnSortList.TabIndex = 5;
            this.btnSortList.Text = "Sort List";
            this.btnSortList.UseVisualStyleBackColor = true;
            this.btnSortList.Click += new System.EventHandler(this.btnSortList_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(294, 215);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 6;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(75, 91);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleInitial.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(75, 128);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // nameSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 261);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnSortList);
            this.Controls.Add(this.txtNameSorterOutput);
            this.Controls.Add(this.lbOutputTextBox);
            this.Controls.Add(this.btnClearForNextAuthor);
            this.Controls.Add(this.btnAddNameToList);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbMiddleInitial);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbPageTitle);
            this.Name = "nameSorter";
            this.Text = "NameSorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPageTitle;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbMiddleInitial;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Button btnAddNameToList;
        private System.Windows.Forms.Button btnClearForNextAuthor;
        private System.Windows.Forms.Label lbOutputTextBox;
        private System.Windows.Forms.TextBox txtNameSorterOutput;
        private System.Windows.Forms.Button btnSortList;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtLastName;
    }
}