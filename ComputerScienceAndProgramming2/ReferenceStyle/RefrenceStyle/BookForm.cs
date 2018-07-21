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
//BookForm Code behind, creates book obj for the form to access, passes values in and prints them out.

namespace ReferenceStyle
{    
    
    public partial class BookForm : Form
    {
        //creates a "book" and passes values into it from the form.
        Book myBook = new Book();
       
        /// <summary>
        /// entry method to innitialize the book form.
        /// </summary>
        public BookForm()
        {
            InitializeComponent();
        }

       

        /// <summary>
        /// event handler for add name button, puts name fields into a list of Name objs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddName_Click(object sender, EventArgs e)
        {
            
            string _first = "", _middle = "", _last = "";
            if (txtFirst.Text == "" && txtMI.Text == "" && txtLast.Text == "")
            {
                MessageBox.Show("fill in the name before adding author.");
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

                myBook.enterNamesList(_first, _middle, _last);
                txtListOfAuthors.Text = myBook.justName();
                txtFirst.Clear();
                txtMI.Clear();
                txtLast.Clear();
                txtFirst.Focus();
            }
            
        }

        /// <summary>
        /// adds all the information in the add book group box into the system, validates int values 
        ///     being passed in as strings here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            myBook.enterTitle(txtBookTitle.Text);
            myBook.City = txtPublisherCity.Text;
            myBook.BookPublisher = txtBookPublisher.Text;
            string day = txtPubDateDay.Text;
            string month = txtPubDateMonth.Text;
            string year = txtPubDateYear.Text;
            int _day = 0;
            int _month = 0;
            int _year = 0;
            if (int.TryParse(day, out  _day)) { }

            if (int.TryParse(month, out _month)) { }

            if (int.TryParse(year, out _year)) { }
            
            myBook.enterDate(_day,_month,_year);
            btnAPAStyle.Enabled = true;
            btnLibMedStyle.Enabled = true;
            btnMLAStyle.Enabled = true;

        }

        
        /// <summary>
        /// access' the refrence class through the book class inheritance to instantiate the Iformat 
        ///     interface and output  the user input data in MLA Format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMLAStyle_Click(object sender, EventArgs e)
        {
            txtViewReferenceStyles.Text = myBook.formatMLA();
        }

        /// <summary>
        /// access' the refrence class through the book class inheritance to instantiate the Iformat 
        ///     interface and output  the user input data in APA Format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAPAStyle_Click(object sender, EventArgs e)
        {
            txtViewReferenceStyles.Text = myBook.formatAPA();
        }

        /// <summary>
        /// access' the refrence class through the book class inheritance to instantiate the Iformat 
        ///     interface and output  the user input data in LibMed Format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLibMedStyle_Click(object sender, EventArgs e)
        {
            txtViewReferenceStyles.Text = myBook.formatLibMed();
        }

        /// <summary>
        /// clears the list of authors so a new list can be add to a new book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAnotherBook_Click(object sender, EventArgs e)
        {
            
            
            ClearTextBoxes(this);
            myBook.newBook();
            btnAPAStyle.Enabled = false;
            btnLibMedStyle.Enabled = false;
            btnMLAStyle.Enabled = false;
            btnAddAnotherBook.Enabled = false;
        }
        /// <summary>
        /// returns user to the program access form, manage references.
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
            btnAddAnotherBook.Enabled = true;
            ManageList.setMyList(myBook);
        }

       
    }
}
