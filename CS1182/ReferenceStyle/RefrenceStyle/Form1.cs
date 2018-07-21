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
    //This is the form that outputs the multiple refrence styles to the form with three output boxes
    //

    public partial class referenceStyleOutputer : Form
    {
        Name myName = new Name();
        Title myTitle = new Title();
        Date myDate = new Date();
        public referenceStyleOutputer()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

       
       /// <summary>
       /// outputs to the Date textbox, runs some checks that involve the data returned from the date class.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnShowDate_Click(object sender, EventArgs e)
        {
            txtDateRefrenceOutput.Clear();

            string _day = txtDay.Text;
            int day = 0;
            string _month = txtMonth.Text;
            string _monthday = txtMonth.Text;
            int month = 0;
            string _year = txtYear.Text;
            int year = 0;
            bool printDay = true;
            bool printMonth = true;
            

            if (int.TryParse(_day, out day))
            {
                myDate.Day = day;
            }
            else
                myDate.Day = 0;

            if (int.TryParse(_month, out month))
            {
                myDate.Month = month;
            }
            else
                myDate.Month = 0;
            if (int.TryParse(_year, out year))
            {
                myDate.Year = year;
                myDate.Day = myDate.validateLeapYear();
            }
            else
                myDate.Year = 0;
            
            
            if (myDate.Day == 0 || myDate.validateLeapYear() ==0)
            {
                printDay = false;
                _day = "";                
            }else
                _day = myDate.Day.ToString();
            if (myDate.Month == 0)
            {
                printMonth = false;
                _month = "";
            }
            else
                _month = myDate.Month.ToString();

            if (myDate.Year == 0)
            {
                
                _year = "";
            }
            else
                _year = myDate.Year.ToString();


            if (printMonth == true)
            {
                txtDateRefrenceOutput.Text += _month + "/";
            }
            if (printDay == true)
            {
                txtDateRefrenceOutput.Text += _day + "/";
            }            
                txtDateRefrenceOutput.Text += _year + "\r\n";
                       
            if (printMonth == true)
            {
                txtDateRefrenceOutput.Text += myDate.MonthName + " ";
            }            
            if (printDay == true)
            {
                txtDateRefrenceOutput.Text += myDate.Day + ", ";
            }           
                txtDateRefrenceOutput.Text += myDate.Year + "\r\n";
                       
            if (printMonth == true)
            {
                txtDateRefrenceOutput.Text += myDate.Month + "/";
            }            
                txtDateRefrenceOutput.Text += myDate.Year + "\r\n";
                        
            if (printMonth == true)
            {
                txtDateRefrenceOutput.Text += myDate.MonthName + ", ";
            }            
                txtDateRefrenceOutput.Text += myDate.Year +  "\r\n";                      
                 txtDateRefrenceOutput.Text += myDate.Year           ;

            

            
            }

    /// <summary>
    /// button event that fills the Names text box, only feeds into the Name class and organizes the output.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void btnNameFormats_Click(object sender, EventArgs e)
        {
            txtNameRefrenceOutput.Clear();
            myName.First = txtFirstName.Text.Trim();
            myName.Middle = txtMiddleInitial.Text.Trim();
            myName.Last = txtLastName.Text.Trim();

            txtNameRefrenceOutput.Text += myName.FirstInitial +      ". ";
            txtNameRefrenceOutput.Text += myName.MiddleInitial +     ". ";
            txtNameRefrenceOutput.Text += myName.Last +            "\r\n";
            txtNameRefrenceOutput.Text += myName.FirstInitial +       " ";
            txtNameRefrenceOutput.Text += myName.MiddleInitial +      " ";
            txtNameRefrenceOutput.Text += myName.Last +            "\r\n";
            txtNameRefrenceOutput.Text += myName.First +              " ";
            txtNameRefrenceOutput.Text += myName.MiddleInitial +      " ";
            txtNameRefrenceOutput.Text += myName.Last +            "\r\n";
            txtNameRefrenceOutput.Text += myName.First +              " ";
            txtNameRefrenceOutput.Text += myName.MiddleInitial +     ". ";
            txtNameRefrenceOutput.Text += myName.Last +            "\r\n";
            txtNameRefrenceOutput.Text += myName.Last +              ", ";
            txtNameRefrenceOutput.Text += myName.FirstInitial +      ". ";
            txtNameRefrenceOutput.Text += myName.MiddleInitial +     ". ";
            txtNameRefrenceOutput.Text += "\r\n" + myName.Last  +    ", ";
            txtNameRefrenceOutput.Text += myName.First +              " ";
            txtNameRefrenceOutput.Text += myName.MiddleInitial +     ". ";
            txtNameRefrenceOutput.Text += "\r\n" + myName.Last +      " ";
            txtNameRefrenceOutput.Text += myName.FirstInitial  +      " ";
            txtNameRefrenceOutput.Text += myName.MiddleInitial           ;
            
        }

        /// <summary>
        /// feeds the Title class, and organizes the output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTitleFormats_Click(object sender, EventArgs e)
        {
            txtTitleOutput.Clear();
            myTitle.AsTyped = txtTitle.Text;

            txtTitleOutput.Text += myTitle.AsTyped + "\r\n";
            txtTitleOutput.Text += myTitle.allCaps() + "\r\n";
            txtTitleOutput.Text += myTitle.firstWordCap() + "\r\n";
            txtTitleOutput.Text += myTitle.allLower() + "\r\n";
            txtTitleOutput.Text += "<i>" + myTitle.AsTyped +"</i>"; 
        }

        



    }
}
