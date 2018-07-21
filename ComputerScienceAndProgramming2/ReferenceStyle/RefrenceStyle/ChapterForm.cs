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
//ChapterForm Code behind, creates book obj for the form to access, passes values in and prints them out.
namespace ReferenceStyle
{
    public partial class ChapterForm : Form
    {
        Chapter myChapter = new Chapter();
        public ChapterForm()
        {
            InitializeComponent();

        }

        
        /// <summary>
        /// adds author, clears fields and returns focus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string _first = "", _middle = "", _last = "";
            if (txtAuthorFirst.Text == "" && txtAuthorMI.Text == "" && txtAuthorLast.Text == "")
            {
                MessageBox.Show("Please fill at least one of the fields.");
                txtAuthorFirst.Focus();
            }
            else
            {
                if (txtAuthorFirst.Text == "")
                {
                    _first = "";
                }
                else
                    _first = txtAuthorFirst.Text;
                if (txtAuthorMI.Text == "")
                {
                    _middle = "";
                }
                else
                    _middle = txtAuthorMI.Text;
                if (txtAuthorLast.Text == "")
                {
                    _last = "";
                }
                else
                    _last = txtAuthorLast.Text;

                myChapter.enterNamesList(_first, _middle, _last);
                txtListOfAuthors.Text = myChapter.justName();
                txtAuthorFirst.Clear();
                txtAuthorMI.Clear();
                txtAuthorLast.Clear();
                txtAuthorFirst.Focus();
            }
            //myChapter.enterNamesList(txtAuthorFirst.Text, txtAuthorMI.Text, txtAuthorLast.Text);
            //txtListOfAuthors.Text = myChapter.justName();
            //txtAuthorFirst.Clear();
            //txtAuthorMI.Clear();
            //txtAuthorLast.Clear();
            //txtAuthorFirst.Focus();
        }
        /// <summary>
        /// adds a name obj to the _editors list to be handled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEditor_Click(object sender, EventArgs e)
        {
            string _first = "", _middle = "", _last = "";
            if (txtEditorFirst.Text == "" && txtEditorMI.Text == "" && txtAuthorLast.Text == "")
            {
                MessageBox.Show("Please fill at least one of the fields.");
                txtEditorFirst.Focus();
            }
            else
            {
                if (txtEditorFirst.Text == "")
                {
                    _first = "";
                }
                else
                    _first = txtEditorFirst.Text;
                if (txtEditorMI.Text == "")
                {
                    _middle = "";
                }
                else
                    _middle = txtEditorMI.Text;
                if (txtEditorLast.Text == "")
                {
                    _last = "";
                }
                else
                    _last = txtEditorLast.Text;


                myChapter.addEditor(txtEditorFirst.Text, txtEditorMI.Text, txtEditorLast.Text);
                txtListOfEditors.Text = myChapter.getEditorNames();
                txtEditorFirst.Clear();
                txtEditorMI.Clear();
                txtEditorLast.Clear();
                txtEditorFirst.Focus();
            }
        }
        /// <summary>
        /// passes data from the form into 
        /// chapterTitle,enterTitle(book title),BookPublisher,City,PublisherState,PublisherCountry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddChapter_Click(object sender, EventArgs e)
        {
            myChapter.chapterTitle = txtChapterTitle.Text;
            myChapter.enterTitle(txtBookTitle.Text);
            myChapter.BookPublisher = txtBookPublisher.Text;                        
            myChapter.City = txtPublisherCity.Text;
            myChapter.PublisherState = txtPublisherState.Text;
            myChapter.PublisherCountry = txtPublisherCountry.Text;
            
            setDate();
            setPageNum();
            btnAPA.Enabled = true;
            btnMLA.Enabled = true;
            btnLibMed.Enabled = true;

        }
        /// <summary>
        /// sets the date from the form info;
        /// enterDate(day,month,year)
        /// </summary>
        void setDate()
        {
            string day = txtPubDateDD.Text;
            string month = txtPubDateMM.Text;
            string year = txtPubDateCCYY.Text;
            int _day = 0;
            int _month = 0;
            int _year = 0;
            if (int.TryParse(day, out  _day)) { }
            if (int.TryParse(month, out _month)) { }
            if (int.TryParse(year, out _year)) { }
            myChapter.enterDate(_day, _month, _year);
        }
        /// <summary>
        /// sets page numbers from form data.
        /// BeginingPageNumber,EndingPageNumber
        /// </summary>
        void setPageNum()
        {
            string beginingPageNum = txtBeginPageNumber.Text;
            string endingPageNum = txtEndPageNumber.Text;
            int _beginPg = 0;
            int _endPg = 0;
            if (int.TryParse(beginingPageNum, out _beginPg)) { }
            if (int.TryParse(endingPageNum, out _endPg)) { }
            myChapter.BeginingPageNumber = _beginPg;
            myChapter.EndingPageNumber = _endPg;
        }

        /// <summary>
        /// fills the view reference styles text box from the overridden construcor in the chapter class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMLA_Click(object sender, EventArgs e)
        {
            txtViewReferenceStyles.Text = myChapter.formatMLA();
        }
        /// <summary>
        /// fills the view reference styles text box from the overridden construcor in the chapter class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAPA_Click(object sender, EventArgs e)
        {

            txtViewReferenceStyles.Text = myChapter.formatAPA();
        }
        /// <summary>
        /// fills the view reference styles text box from the overridden construcor in the chapter class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLibMed_Click(object sender, EventArgs e)
        {
            txtViewReferenceStyles.Text = myChapter.formatLibMed();
        }

        private void btnAddAnotherChapter_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
            btnLibMed.Enabled = false;
            btnAPA.Enabled = false;
            btnMLA.Enabled = false;
            btnAddAnotherChapter.Enabled = false;

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
        /// <summary>
        /// closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnToManageReferences_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// terminates the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddToReferenceList_Click(object sender, EventArgs e)
        {
            btnAddAnotherChapter.Enabled = true;
            ManageList.setMyList(myChapter);
        }

    }
}
