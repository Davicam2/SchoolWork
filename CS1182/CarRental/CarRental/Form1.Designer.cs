namespace CarRental
{
    partial class fmRentalReturn
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
            this.lblUnitRented = new System.Windows.Forms.Label();
            this.cmbUnitRented = new System.Windows.Forms.ComboBox();
            this.lblCostPerDay = new System.Windows.Forms.Label();
            this.txtCostPerDay = new System.Windows.Forms.TextBox();
            this.lblCostPerMile = new System.Windows.Forms.Label();
            this.txtCostPerMile = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMI = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.lblBeginningMileage = new System.Windows.Forms.Label();
            this.lblEndingMileage = new System.Windows.Forms.Label();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtNumberOfDays = new System.Windows.Forms.TextBox();
            this.txtBeginningMileage = new System.Windows.Forms.TextBox();
            this.txtEndingMileage = new System.Windows.Forms.TextBox();
            this.gbGasTankOnReturn = new System.Windows.Forms.GroupBox();
            this.rbtnFullTank = new System.Windows.Forms.RadioButton();
            this.rbtnThreeFourths = new System.Windows.Forms.RadioButton();
            this.rbtnOneHalf = new System.Windows.Forms.RadioButton();
            this.rbtnOneFourth = new System.Windows.Forms.RadioButton();
            this.rbtnEmpty = new System.Windows.Forms.RadioButton();
            this.gbDiscounts = new System.Windows.Forms.GroupBox();
            this.ckbFrequentRenter = new System.Windows.Forms.CheckBox();
            this.ckbSeniorCitizen = new System.Windows.Forms.CheckBox();
            this.txtRentalBill = new System.Windows.Forms.TextBox();
            this.lblRentalBill = new System.Windows.Forms.Label();
            this.erpvdFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpvdLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpvdNumberOfDays = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpvdBeginningMileage = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpvdEndingMileage = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGasTankOnReturn.SuspendLayout();
            this.gbDiscounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdNumberOfDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdBeginningMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdEndingMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnitRented
            // 
            this.lblUnitRented.AutoSize = true;
            this.lblUnitRented.Location = new System.Drawing.Point(85, 9);
            this.lblUnitRented.Name = "lblUnitRented";
            this.lblUnitRented.Size = new System.Drawing.Size(83, 17);
            this.lblUnitRented.TabIndex = 0;
            this.lblUnitRented.Text = "Unit Rented";
            // 
            // cmbUnitRented
            // 
            this.cmbUnitRented.FormattingEnabled = true;
            this.cmbUnitRented.Location = new System.Drawing.Point(36, 30);
            this.cmbUnitRented.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnitRented.Name = "cmbUnitRented";
            this.cmbUnitRented.Size = new System.Drawing.Size(189, 24);
            this.cmbUnitRented.TabIndex = 0;
            this.cmbUnitRented.SelectedIndexChanged += new System.EventHandler(this.cmbUnitRented_SelectedIndexChanged);
            // 
            // lblCostPerDay
            // 
            this.lblCostPerDay.AutoSize = true;
            this.lblCostPerDay.Location = new System.Drawing.Point(251, 33);
            this.lblCostPerDay.Name = "lblCostPerDay";
            this.lblCostPerDay.Size = new System.Drawing.Size(91, 17);
            this.lblCostPerDay.TabIndex = 15;
            this.lblCostPerDay.Text = "Cost Per Day";
            // 
            // txtCostPerDay
            // 
            this.txtCostPerDay.Location = new System.Drawing.Point(357, 30);
            this.txtCostPerDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostPerDay.Name = "txtCostPerDay";
            this.txtCostPerDay.ReadOnly = true;
            this.txtCostPerDay.Size = new System.Drawing.Size(129, 22);
            this.txtCostPerDay.TabIndex = 10;
            // 
            // lblCostPerMile
            // 
            this.lblCostPerMile.AutoSize = true;
            this.lblCostPerMile.Location = new System.Drawing.Point(527, 33);
            this.lblCostPerMile.Name = "lblCostPerMile";
            this.lblCostPerMile.Size = new System.Drawing.Size(91, 17);
            this.lblCostPerMile.TabIndex = 11;
            this.lblCostPerMile.Text = "Cost Per Mile";
            // 
            // txtCostPerMile
            // 
            this.txtCostPerMile.Location = new System.Drawing.Point(644, 30);
            this.txtCostPerMile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostPerMile.Name = "txtCostPerMile";
            this.txtCostPerMile.ReadOnly = true;
            this.txtCostPerMile.Size = new System.Drawing.Size(129, 22);
            this.txtCostPerMile.TabIndex = 12;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(36, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Location = new System.Drawing.Point(36, 123);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(22, 17);
            this.lblMI.TabIndex = 7;
            this.lblMI.Text = "MI";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(36, 156);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(36, 187);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(110, 17);
            this.lblNumberOfDays.TabIndex = 9;
            this.lblNumberOfDays.Text = "Number of Days";
            // 
            // lblBeginningMileage
            // 
            this.lblBeginningMileage.AutoSize = true;
            this.lblBeginningMileage.Location = new System.Drawing.Point(36, 222);
            this.lblBeginningMileage.Name = "lblBeginningMileage";
            this.lblBeginningMileage.Size = new System.Drawing.Size(124, 17);
            this.lblBeginningMileage.TabIndex = 10;
            this.lblBeginningMileage.Text = "Beginning Mileage";
            // 
            // lblEndingMileage
            // 
            this.lblEndingMileage.AutoSize = true;
            this.lblEndingMileage.Location = new System.Drawing.Point(39, 252);
            this.lblEndingMileage.Name = "lblEndingMileage";
            this.lblEndingMileage.Size = new System.Drawing.Size(105, 17);
            this.lblEndingMileage.TabIndex = 11;
            this.lblEndingMileage.Text = "Ending Mileage";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Location = new System.Drawing.Point(43, 290);
            this.btnPrintBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(75, 23);
            this.btnPrintBill.TabIndex = 9;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(171, 87);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(171, 153);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(171, 121);
            this.txtMI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(23, 22);
            this.txtMI.TabIndex = 2;
            // 
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.Location = new System.Drawing.Point(171, 185);
            this.txtNumberOfDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfDays.TabIndex = 4;
            // 
            // txtBeginningMileage
            // 
            this.txtBeginningMileage.Location = new System.Drawing.Point(171, 218);
            this.txtBeginningMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBeginningMileage.Name = "txtBeginningMileage";
            this.txtBeginningMileage.Size = new System.Drawing.Size(100, 22);
            this.txtBeginningMileage.TabIndex = 5;
            // 
            // txtEndingMileage
            // 
            this.txtEndingMileage.Location = new System.Drawing.Point(171, 249);
            this.txtEndingMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndingMileage.Name = "txtEndingMileage";
            this.txtEndingMileage.Size = new System.Drawing.Size(100, 22);
            this.txtEndingMileage.TabIndex = 6;
            // 
            // gbGasTankOnReturn
            // 
            this.gbGasTankOnReturn.Controls.Add(this.rbtnFullTank);
            this.gbGasTankOnReturn.Controls.Add(this.rbtnThreeFourths);
            this.gbGasTankOnReturn.Controls.Add(this.rbtnOneHalf);
            this.gbGasTankOnReturn.Controls.Add(this.rbtnOneFourth);
            this.gbGasTankOnReturn.Controls.Add(this.rbtnEmpty);
            this.gbGasTankOnReturn.Location = new System.Drawing.Point(357, 87);
            this.gbGasTankOnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGasTankOnReturn.Name = "gbGasTankOnReturn";
            this.gbGasTankOnReturn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGasTankOnReturn.Size = new System.Drawing.Size(177, 182);
            this.gbGasTankOnReturn.TabIndex = 7;
            this.gbGasTankOnReturn.TabStop = false;
            this.gbGasTankOnReturn.Text = "Gas Tank On Return";
            // 
            // rbtnFullTank
            // 
            this.rbtnFullTank.AutoSize = true;
            this.rbtnFullTank.Location = new System.Drawing.Point(7, 144);
            this.rbtnFullTank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnFullTank.Name = "rbtnFullTank";
            this.rbtnFullTank.Size = new System.Drawing.Size(87, 21);
            this.rbtnFullTank.TabIndex = 4;
            this.rbtnFullTank.TabStop = true;
            this.rbtnFullTank.Text = "Full Tank";
            this.rbtnFullTank.UseVisualStyleBackColor = true;
            // 
            // rbtnThreeFourths
            // 
            this.rbtnThreeFourths.AutoSize = true;
            this.rbtnThreeFourths.Location = new System.Drawing.Point(7, 117);
            this.rbtnThreeFourths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnThreeFourths.Name = "rbtnThreeFourths";
            this.rbtnThreeFourths.Size = new System.Drawing.Size(75, 21);
            this.rbtnThreeFourths.TabIndex = 3;
            this.rbtnThreeFourths.TabStop = true;
            this.rbtnThreeFourths.Text = "3/4 Full";
            this.rbtnThreeFourths.UseVisualStyleBackColor = true;
            // 
            // rbtnOneHalf
            // 
            this.rbtnOneHalf.AutoSize = true;
            this.rbtnOneHalf.Location = new System.Drawing.Point(5, 90);
            this.rbtnOneHalf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnOneHalf.Name = "rbtnOneHalf";
            this.rbtnOneHalf.Size = new System.Drawing.Size(75, 21);
            this.rbtnOneHalf.TabIndex = 2;
            this.rbtnOneHalf.TabStop = true;
            this.rbtnOneHalf.Text = "1/2 Full";
            this.rbtnOneHalf.UseVisualStyleBackColor = true;
            // 
            // rbtnOneFourth
            // 
            this.rbtnOneFourth.AutoSize = true;
            this.rbtnOneFourth.Location = new System.Drawing.Point(5, 63);
            this.rbtnOneFourth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnOneFourth.Name = "rbtnOneFourth";
            this.rbtnOneFourth.Size = new System.Drawing.Size(75, 21);
            this.rbtnOneFourth.TabIndex = 1;
            this.rbtnOneFourth.TabStop = true;
            this.rbtnOneFourth.Text = "1/4 Full";
            this.rbtnOneFourth.UseVisualStyleBackColor = true;
            // 
            // rbtnEmpty
            // 
            this.rbtnEmpty.AutoSize = true;
            this.rbtnEmpty.Location = new System.Drawing.Point(5, 36);
            this.rbtnEmpty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnEmpty.Name = "rbtnEmpty";
            this.rbtnEmpty.Size = new System.Drawing.Size(68, 21);
            this.rbtnEmpty.TabIndex = 0;
            this.rbtnEmpty.TabStop = true;
            this.rbtnEmpty.Text = "Empty";
            this.rbtnEmpty.UseVisualStyleBackColor = true;
            // 
            // gbDiscounts
            // 
            this.gbDiscounts.Controls.Add(this.ckbFrequentRenter);
            this.gbDiscounts.Controls.Add(this.ckbSeniorCitizen);
            this.gbDiscounts.Location = new System.Drawing.Point(585, 90);
            this.gbDiscounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDiscounts.Name = "gbDiscounts";
            this.gbDiscounts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDiscounts.Size = new System.Drawing.Size(171, 85);
            this.gbDiscounts.TabIndex = 8;
            this.gbDiscounts.TabStop = false;
            this.gbDiscounts.Text = "Discounts";
            // 
            // ckbFrequentRenter
            // 
            this.ckbFrequentRenter.AutoSize = true;
            this.ckbFrequentRenter.Location = new System.Drawing.Point(5, 49);
            this.ckbFrequentRenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbFrequentRenter.Name = "ckbFrequentRenter";
            this.ckbFrequentRenter.Size = new System.Drawing.Size(134, 21);
            this.ckbFrequentRenter.TabIndex = 1;
            this.ckbFrequentRenter.Text = "Frequent Renter";
            this.ckbFrequentRenter.UseVisualStyleBackColor = true;
            // 
            // ckbSeniorCitizen
            // 
            this.ckbSeniorCitizen.AutoSize = true;
            this.ckbSeniorCitizen.Location = new System.Drawing.Point(7, 22);
            this.ckbSeniorCitizen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbSeniorCitizen.Name = "ckbSeniorCitizen";
            this.ckbSeniorCitizen.Size = new System.Drawing.Size(117, 21);
            this.ckbSeniorCitizen.TabIndex = 0;
            this.ckbSeniorCitizen.Text = "Senior Citizen";
            this.ckbSeniorCitizen.UseVisualStyleBackColor = true;
            // 
            // txtRentalBill
            // 
            this.txtRentalBill.Location = new System.Drawing.Point(43, 386);
            this.txtRentalBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRentalBill.Multiline = true;
            this.txtRentalBill.Name = "txtRentalBill";
            this.txtRentalBill.Size = new System.Drawing.Size(809, 162);
            this.txtRentalBill.TabIndex = 21;
            // 
            // lblRentalBill
            // 
            this.lblRentalBill.AutoSize = true;
            this.lblRentalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalBill.Location = new System.Drawing.Point(61, 354);
            this.lblRentalBill.Name = "lblRentalBill";
            this.lblRentalBill.Size = new System.Drawing.Size(133, 29);
            this.lblRentalBill.TabIndex = 22;
            this.lblRentalBill.Text = "Rental Bill";
            // 
            // erpvdFirstName
            // 
            this.erpvdFirstName.ContainerControl = this;
            // 
            // erpvdLastName
            // 
            this.erpvdLastName.ContainerControl = this;
            // 
            // erpvdNumberOfDays
            // 
            this.erpvdNumberOfDays.ContainerControl = this;
            // 
            // erpvdBeginningMileage
            // 
            this.erpvdBeginningMileage.ContainerControl = this;
            // 
            // erpvdEndingMileage
            // 
            this.erpvdEndingMileage.ContainerControl = this;
            // 
            // fmRentalReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 560);
            this.Controls.Add(this.lblRentalBill);
            this.Controls.Add(this.txtRentalBill);
            this.Controls.Add(this.gbDiscounts);
            this.Controls.Add(this.gbGasTankOnReturn);
            this.Controls.Add(this.txtEndingMileage);
            this.Controls.Add(this.txtBeginningMileage);
            this.Controls.Add(this.txtNumberOfDays);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.lblEndingMileage);
            this.Controls.Add(this.lblBeginningMileage);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtCostPerMile);
            this.Controls.Add(this.lblCostPerMile);
            this.Controls.Add(this.txtCostPerDay);
            this.Controls.Add(this.lblCostPerDay);
            this.Controls.Add(this.cmbUnitRented);
            this.Controls.Add(this.lblUnitRented);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fmRentalReturn";
            this.Text = "Rental Return";
            this.gbGasTankOnReturn.ResumeLayout(false);
            this.gbGasTankOnReturn.PerformLayout();
            this.gbDiscounts.ResumeLayout(false);
            this.gbDiscounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdNumberOfDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdBeginningMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpvdEndingMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnitRented;
        private System.Windows.Forms.ComboBox cmbUnitRented;
        private System.Windows.Forms.Label lblCostPerDay;
        private System.Windows.Forms.TextBox txtCostPerDay;
        private System.Windows.Forms.Label lblCostPerMile;
        private System.Windows.Forms.TextBox txtCostPerMile;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblBeginningMileage;
        private System.Windows.Forms.Label lblEndingMileage;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtNumberOfDays;
        private System.Windows.Forms.TextBox txtBeginningMileage;
        private System.Windows.Forms.TextBox txtEndingMileage;
        private System.Windows.Forms.GroupBox gbGasTankOnReturn;
        private System.Windows.Forms.RadioButton rbtnFullTank;
        private System.Windows.Forms.RadioButton rbtnThreeFourths;
        private System.Windows.Forms.RadioButton rbtnOneHalf;
        private System.Windows.Forms.RadioButton rbtnOneFourth;
        private System.Windows.Forms.RadioButton rbtnEmpty;
        private System.Windows.Forms.GroupBox gbDiscounts;
        private System.Windows.Forms.CheckBox ckbFrequentRenter;
        private System.Windows.Forms.CheckBox ckbSeniorCitizen;
        private System.Windows.Forms.TextBox txtRentalBill;
        private System.Windows.Forms.Label lblRentalBill;
        private System.Windows.Forms.ErrorProvider erpvdFirstName;
        private System.Windows.Forms.ErrorProvider erpvdLastName;
        private System.Windows.Forms.ErrorProvider erpvdNumberOfDays;
        private System.Windows.Forms.ErrorProvider erpvdBeginningMileage;
        private System.Windows.Forms.ErrorProvider erpvdEndingMileage;
    }
}

