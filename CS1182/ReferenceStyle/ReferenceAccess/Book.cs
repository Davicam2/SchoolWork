using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
//Cameron Davis 
//CS 1182
//book class acts as the data access for the BookForm
namespace ReferenceAccess

{
    public class Book : Reference
    {
        string _publisher = "";
        /// <summary>
        /// returns the publisher of item in question
        /// </summary>
        public string BookPublisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
                
            }
        }
        public override string formatMLA()
        {
            return getLastFirstMi() + " " + "<i>" + getAllCaps() + "</i>" + ". " + City + ": " + BookPublisher +
               ", " + getYear() + ".";
        }
        public override string formatAPA()
        {
            return getLastFiMi_FirstMiLast() + ". " + getYear() + ". " + myTitle.firstWordCap() + ". " +
               City + ": " + BookPublisher + "."; 
        }
        public override string formatLibMed()
        {
            
            return getLastFiMiNoCommaNoDot() + " " + getAllCaps() + ". " + City + ": " +
               BookPublisher + "; " + getYear() + ".";
        }

        /// <summary>
        /// clears the list of author names so another book with new authors can 
        /// be added.
        /// </summary>
        public void newBook()
        {
            
            listOfNamesClear();
        }
    }
}
