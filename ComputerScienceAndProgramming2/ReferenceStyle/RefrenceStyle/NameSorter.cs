using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrenceStyle
{
    //Cameron Davis
    //CS 1182
    // This is the code behind for the NameSorter Form, that can output a list and sort it.
    //

    public partial class nameSorter : Form
    {

        private List<Name> _listOfNames = new List<Name>();
        Name myName = new Name();

        public nameSorter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method called to populate the only output text box on the form
        /// </summary>
        private void listOutput()
        {
            txtNameSorterOutput.Clear();
            foreach (Name names in _listOfNames)
            {
                txtNameSorterOutput.Text += names.Last + " " + names.FirstInitial + names.MiddleInitial;
                txtNameSorterOutput.Text += "\r\n";
            }

        }

        /// <summary>
        /// adds the 3 user input fields into the Name class, and creates a list item with said values stored in it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNameToList_Click(object sender, EventArgs e)
        {
            myName = new Name();
            myName.First = txtFirstName.Text;
            myName.Middle = txtMiddleInitial.Text;
            myName.Last = txtLastName.Text;
            _listOfNames.Add(myName);
            txtNameSorterOutput.Clear();
            listOutput();
            

            
        }
               
        /// <summary>
        /// calls the sort function, and populates the output txtbox with the sorted items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortList_Click(object sender, EventArgs e)
        {
            txtNameSorterOutput.Clear();
            _listOfNames.Sort();
            listOutput();

        }
        
        /// <summary>
        /// Clears the user input fields, and puts the focus on the tab[0] object on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearForNextAuthor_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInitial.Clear();
            txtFirstName.Focus();
        }

        /// <summary>
        /// deleats all objects in the _listOfNames list, clears the output textbox, and puts focus on tab[0] object. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearList_Click(object sender, EventArgs e)
        {
            _listOfNames.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInitial.Clear();
            txtFirstName.Focus();
            listOutput();
        }
        


    }
}
