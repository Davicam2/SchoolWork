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
using System.IO;
using System.Drawing.Printing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;




//Cameron Davis 
//CS 1182
//innital form opened when program is run, allows access to the book, chapter and journal forms,
//as well as contains dropdown menu with many fields.
namespace ReferenceStyle
{
    public partial class ManageReferencesForm : Form
    {

        //global variable instantiation
        Form bookForm = new BookForm();
        Form chapterForm = new ChapterForm();
        Form journalForm = new JournalForm();
        
        //StreamWriter sWriter;
        
        public ManageReferencesForm()
        {
            InitializeComponent();
        }
                                
      /// <summary>
      /// opens a new book form.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookForm = new BookForm();
            bookForm.Show();
        }

        /// <summary>
        /// opens a new chapter form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chapterForm = new ChapterForm();
            chapterForm.Show();
            
        }
        /// <summary>
        /// opens a new journal form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            journalForm = new JournalForm();
            journalForm.Show();
        }

        /// <summary>
        /// reacts when the radio buttons selected button is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnViewMLA_CheckedChanged(object sender, EventArgs e)
        {
            string References = "";
            if (rbtnViewMLA.Checked == true)
            {
                foreach (Reference myReference in ManageList.getReferenceList())
                {
                    References += myReference.formatMLA() + "\r\n";

                }
                rtxtReferences.Text = References;
            }
            else
                References = "";
            if (rbtnViewAPA.Checked == true)
            {
                foreach (Reference myReference in ManageList.getReferenceList())
                {
                    References += myReference.formatAPA() + "\r\n";

                }
                rtxtReferences.Text = References;
            }
            else
                References = "";
            if (rbtnViewLibMed.Checked == true)
            {
                foreach (Reference myReference in ManageList.getReferenceList())
                {
                    References += myReference.formatLibMed() + "\r\n";

                }
                rtxtReferences.Text = References;
            }
            else
                References = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveRefrencesToADataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ManageList> binData = new List<ManageList>(); //ManageList.getReferenceList();  
            
            
            if (rtxtReferences.Text != "")
            {
                SaveFileDialog ofd = new SaveFileDialog();
                                
                ofd.DefaultExt = "*.dat";
                ofd.Filter = "DAT Files|*.dat";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK && ofd.FileName.Length > 0)
                {                  
                        try
                        {
                            
                            FileStream stream = new FileStream(ofd.FileName, FileMode.Create, FileAccess.Write);
                            
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, binData);
                            stream.Close();
                            MessageBox.Show("File has been writen");
                        }
                        catch
                        {
                            MessageBox.Show("Error Saving to this file");
                        }
                    }                               
            }
            else
            {
                MessageBox.Show("Display references before saving");
            }
            
        }
        /// <summary>
        /// allows user to select a file, or create a new one of type rtf for their references.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printRefrencesToADocumentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (rtxtReferences.Text != "")
            {
                SaveFileDialog ofd = new SaveFileDialog();

                

                ofd.DefaultExt = "*.rtf";
                ofd.Filter = "RTF Files|*.rtf";
               
                // code borrowed from
                //https://msdn.microsoft.com/en-us/library/e4a710b1(v=vs.110).aspx
                
                



                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK && ofd.FileName.Length > 0)
                {
                    // Save the contents of the RichTextBox into the file.
                    rtxtReferences.SaveFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                }

                //File.WriteAllText(filePath, rtxtReferences.Text);
                //PrintDocument doc = new PrintDocument();
                //doc.PrintPage += new PrintPageEventHandler(this.printThePage);
                //doc.Print();
                



            }
            else
            {
                MessageBox.Show("Display references before saving");
            }
       }
        /// <summary>
        /// opens the references saved from a previous Reference entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openRefrencesFromADataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "DAT Files|*.dat";
            BinaryFormatter bin = new BinaryFormatter();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<ManageList> binData = new List<ManageList>();
                if (File.Exists(open.FileName))
                {
                    try
                    {
                        FileStream stream = new FileStream(open.FileName, FileMode.Open, FileAccess.Read);
                        binData = (List<ManageList>)bin.Deserialize(stream);
                        stream.Close();
                        foreach (Reference refs in ManageList.getReferenceList())
                        {
                            rtxtReferences.Text += refs.formatAPA();
                        }
                        // rtxtReferences.Text = ManageList.getReferenceList().ToString();
                        
                    }
                    catch
                    {
                        MessageBox.Show("Error reading from file");
                    }
                }
                                                                                                              
            }


        }

        private void startNewRefrenceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageList.clearList();
            rtxtReferences.Clear();
            
            MessageBox.Show("References have been cleared");
            
        }
        /// <summary>
        /// all code from http://www.c-sharpcorner.com/uploadfile/puranindia/pagesetupdialog-in-C-Sharp/
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            //setup.ShowDialog();
            PageSetupDialog setupDlg = new PageSetupDialog();
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";

            //PageSetupDialog settings
            setupDlg.Document = printDoc;
            setupDlg.AllowMargins = true;
            setupDlg.AllowOrientation = true;
            setupDlg.AllowPaper = true;
            setupDlg.AllowPrinter = true;

            if (rtxtReferences.Text != "")
            {
                if (setupDlg.ShowDialog() == DialogResult.OK)
                {
                    printDoc.DefaultPageSettings = setupDlg.PageSettings;
                    printDoc.PrinterSettings = setupDlg.PrinterSettings;
                }
            }
            else
            {
                MessageBox.Show("Display References before Printing them");
            }
        }
        /// <summary>
        /// all code from http://www.c-sharpcorner.com/uploadfile/puranindia/pagesetupdialog-in-C-Sharp/
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a PrintPreviewDialog object
            PrintPreviewDialog previewDlg = new PrintPreviewDialog();

            //Create a PrintDocument object
            PrintDocument printDoc = new PrintDocument();

            //Set Document property
            previewDlg.Document = printDoc;
            previewDlg.WindowState = FormWindowState.Normal;
            //show Dialog
            previewDlg.ShowDialog();
        }
        /// <summary>
        /// http://stackoverflow.com/questions/17448465/send-pdf-file-to-a-printer-print-pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printReferencesToAPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = rtxtReferences.Text;//"Print Document";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
            if (false == p.CloseMainWindow())
                p.Kill();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string developer = "Cameron W Davis";
            string programTitle = "Quick Cite CS1182 Project";
            string programFunction = "This program was developed to allow the user to input the requested " +
                "information about Referenced material and creates the citeations in MLA, APA, and Library " +
                "of Medicine style formats";
            //int totalLength = 100;
            //programFunction = programFunction.PadLeft(((totalLength - programFunction.Length) / 2)
            //                + programFunction.Length).PadRight(totalLength);

            string about = string.Format(" Developer {0} \r\n\r\n {1} \r\n\r\n {2} ", developer, programTitle, programFunction);
            MessageBox.Show(about);
        }
            

        //private void printThePage(object sender, PrintPageEventArgs e)
        //{
        //    float topMargin = e.MarginBounds.Top;
        //    float leftMargin = e.MarginBounds.Left;
        //    float pageHeight = e.MarginBounds.Height;
        //    Font myFont = new Font(FontFamily.GenericSansSerif, 12.0f);
        //    Brush myBrush = new SolidBrush(Color.FromArgb(100, 50, 70));
        //    float lineSize = myFont.GetHeight(e.Graphics);
        //    float linesOnPage = pageHeight / lineSize;

        //    float increment = 0;
        //    float lineCount = 0;
        //    string line = null;

        //    while (lineCount < linesOnPage && ((line = sWriter.ToString()) != null))    
        //    {
        //        e.Graphics.DrawString(line, myFont, myBrush, leftMargin, topMargin + increment);
        //        increment += lineSize;
        //        lineCount++;
        //    }

        //    if (line != null)
        //    {
        //        e.HasMorePages = true;
        //    }
        //    else
        //    {

        //    }
            
        //}               

    }
}
