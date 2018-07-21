using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceAccess;
//Cameron Davis 
//CS 1182
//JournalForm Code behind, creates book obj for the form to access, passes values in and prints them out.
namespace ReferenceStyle
{
    public partial class JournalForm : Form
    {
        Journal myJournal = new Journal();
        public JournalForm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// adds author, clears fields and returns focus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAuthors_Click(object sender, EventArgs e)
        {

            string _first = "", _middle = "", _last = "";
            if (txtFirst.Text == "" && txtMI.Text == "" && txtLast.Text == "")
            {
                MessageBox.Show("Please fill at least one of the fields.");
                txtFirst.Focus();
            }
            else
            {
                if (txtFirst.Text == "")
                {
                    _first = "";
                }
                else
                    _first = txtFirst.Text;
                if (txtMI.Text == "")
                {
                    _middle = "";
                }
                else
                    _middle = txtMI.Text;
                if (txtLast.Text == "")
                {
                    _last = "";
                }
                else
                    _last = txtLast.Text;

                myJournal.enterNamesList(_first, _middle, _last);
                txtListOfAuthors.Text = myJournal.justName();
                txtFirst.Clear();
                txtMI.Clear();
                txtLast.Clear();
                txtFirst.Focus();
            }
           

        }

        /// <summary>
        /// adds all fields in range of the button and enables reference buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddJournal_Click(object sender, EventArgs e)
        {
            myJournal.enterTitle( txtJournalTitle.Text);
            myJournal.JournalName = txtJournalName.Text;
            setVolume();
            setNumber();
            setPageNum();
            setDate();
            btnViewAPA.Enabled = true;
            btnViewMLA.Enabled = true;
            btnViewLibMed.Enabled = true;
        }
        /// <summary>
        /// sets page numbers from form data.
        /// BeginingPageNumber,EndingPageNumber
        /// </summary>
        void setPageNum()
        {
            string beginingPageNum = txtBeginPageNum.Text;
            string endingPageNum = txtEndPageNum.Text;
            int _beginPg = 0;
            int _endPg = 0;
            if (int.TryParse(beginingPageNum, out _beginPg)) { }
            if (int.TryParse(endingPageNum, out _endPg)) { }
            myJournal.BeginingPageNumber = _beginPg;
            myJournal.EndingPageNumber = _endPg;
        }
        /// <summary>
        /// sets the date from the form info;
        /// enterDate(day,month,year)
        /// </summary>
        void setDate()
        {
            string day = txtDay.Text;
            string month = txtMonth.Text;
            string year = txtYear.Text;
            int _day = 0;
            int _month = 0;
            int _year = 0;
            if (int.TryParse(day, out  _day)) { }
            if (int.TryParse(month, out _month)) { }
            if (int.TryParse(year, out _year)) { }
            myJournal.enterDate(_day, _month, _year);
        }
        /// <summary>
        /// validates volume input.
        /// </summary>
        void setVolume()
        {
            
            string volumeNum = txtVolume.Text;
            int _volumeNum = 0;

            if (int.TryParse(volumeNum, out _volumeNum)) { }
            
            myJournal.VolumeNumber = _volumeNum;
            
        }
        /// <summary>
        /// validate Number input.
        /// </summary>
        void setNumber()
        {

            string number = txtNumber.Text;
            int _number = 0;

            if (int.TryParse(number, out _number)) { }

            myJournal.Number = _number;

        }
        /// <summary>
        /// fills the text box with the overridden constructor in Journal class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewMLA_Click(object sender, EventArgs e)
        {
            txtViewReferenceStyles.Text = myJournal.formatMLA();
        }
        /// <summary>
        /// fills the text box with the overridden constructor in Journal class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewAPA_Click(object sender, EventArgs e)
        {
            txtViewReferenceStyles.Text = myJournal.formatAPA();
        }

        /// <summary>
        /// fills the text box with the overridden constructor in Journal class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewLibMed_Click(object sender, EventArgs e)
        {
            txtViewReferenceStyles.Text = myJournal.formatLibMed();
        }
        /// <summary>
        /// clears the list of authors so a new list can be add to a new book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAnotherJournal_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
            myJournal.newJournal();
            btnViewAPA.Enabled = false;
            btnViewLibMed.Enabled = false;
            btnViewMLA.Enabled = false;
            btnAddAnotherJournal.Enabled = false;
        }
       
        /// <summary>
        /// closes this form on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnToManageReferences_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// terminates the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// clears the form.
        ///  little help from 
        ///   http://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form
        ///   "Chandan Pasunoori"
        /// </summary>
        /// <param name="control"></param>
        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        private void btnAddtoReferenceList_Click(object sender, EventArgs e)
        {
            btnAddAnotherJournal.Enabled = true;
            ManageList.setMyList(myJournal);
        }
    }
}
