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
    
    public partial class testPublicationDate : Form
    {

        Reference dataAccess = new Reference();

        public testPublicationDate()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            txtFormatStylesOutput.Clear();
            dataAccess.enterNamesList(txtFirstName.Text, txtMiddleInit.Text, txtLastName.Text);                       
        }

        private void btnAddTitleAndDate_Click(object sender, EventArgs e)
        {
            txtFormatStylesOutput.Clear();
            int _day, _month, _year = 0;
            int.TryParse(txtPublicationDay.Text, out _day);
            int.TryParse(txtPublicationMonth.Text, out _month);
            int.TryParse(txtPublicationYear.Text, out _year);
            
            dataAccess.enterDate(_day, _month, _year);
            dataAccess.enterTitle(txtTitle.Text);
        }
       

        private void btnAnotherAuthor_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInit.Clear();
            txtFirstName.Focus();
        }

        private void btnShowFormats_Click(object sender, EventArgs e)
        {
            txtFormatStylesOutput.Clear();
            mainOutput();
        }
        private void mainOutput()
        {
            txtFormatStylesOutput.Text += "Titles" + "\r\n";
            txtFormatStylesOutput.Text += dataAccess.getAsTyped() + "\r\n";
            txtFormatStylesOutput.Text += dataAccess.getAllCaps() + "\r\n";
            txtFormatStylesOutput.Text += dataAccess.getFirstWordCap() + "\r\n";
            txtFormatStylesOutput.Text += dataAccess.getAllLower() + "\r\n";

            txtFormatStylesOutput.Text += "Dates" + "\r\n";
            txtFormatStylesOutput.Text += dataAccess.getMoDayYear();
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getMonthDayYear();
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getMoYear();
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getMonthYear();
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getYear() + "\r\n";

            txtFormatStylesOutput.Text += "Names" + "\r\n";
            txtFormatStylesOutput.Text += dataAccess.getLastFirstMi();
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getLastFiMi() ;
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getLastFiMi_FirstMiLast() ;
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getLastFirstMi_FirstMiLast();
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getLastFiMiNoCommaNoDot();
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getFiMiLast();
            txtFormatStylesOutput.Text += "\r\n" + dataAccess.getFirstMiLast();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtFormatStylesOutput.Clear();
            txtFirstName.Clear();
            txtMiddleInit.Clear();
            txtLastName.Clear();
            txtPublicationDay.Clear();
            txtPublicationMonth.Clear();
            txtPublicationYear.Clear();
            txtTitle.Clear();
            dataAccess.listClear();
        }

        private void btnItalicized_Click(object sender, EventArgs e)
        {
            rtxtItalicizedTitle.Text += "Title ";            
            rtxtItalicizedTitle.SelectionStart = 6;                         // italics info from
            rtxtItalicizedTitle.Text += dataAccess.getAllCaps();            // http://www.c-sharpcorner.com/Forums/Thread/31638/formatting-output-strings.aspx
            rtxtItalicizedTitle.SelectionLength = dataAccess.getAllCaps().Length;
            rtxtItalicizedTitle.SelectionFont = new Font(rtxtItalicizedTitle.Font, FontStyle.Italic);
            rtxtItalicizedTitle.SelectionLength = 7; 
            rtxtItalicizedTitle.Text += " end";
        }

        
    }
}
