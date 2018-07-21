using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cameron Davis 
//CS 1182
//Journal class, acts as data access for the JournalForm.
namespace ReferenceAccess

{
    public class Journal : Reference
    {
        int _beginPageNum = 0;
        int _endPageNum = 0;
        int _volume = 0;
        int _Number = 0;
        string _journalName = "";

        public int BeginingPageNumber
        {
            get
            {
                return _beginPageNum;
            }
            set
            {
                _beginPageNum = value;

            }
        }
        public int EndingPageNumber
        {
            get
            {
                return _endPageNum;
            }
            set
            {
                _endPageNum = value;
                if (_beginPageNum > _endPageNum)
                {
                    _endPageNum = 0;
                    _beginPageNum = 0;
                }
            }
        }
        public string JournalName
        {
            get
            {
                return _journalName;
            }
            set
            {
                _journalName = value;

            }
        }

        public int VolumeNumber
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
        }
        public int Number
        {
            get
            {
                return _Number;

            }
            set
            {
                _Number = value;
            }
        }

        public void newJournal()
        {
            listOfNamesClear();
        }

        public override string formatMLA()
        {
           
           return getLastFiMi_FirstMiLast() + ". '\u0022'" + getAsTyped() + ".'\u0022'" + JournalName +
               " " + VolumeNumber + "." + Number + " (" + getYear() + "): " + BeginingPageNumber + "-" +
                   EndingPageNumber;
        }
        public override string formatAPA()
        {
            return getLastFiMi() + ". " + "(" + getYear() + "). " + getAsTyped() + ". " + JournalName +
                ", " + VolumeNumber + " (" + Number + "), " + BeginingPageNumber + "-" + EndingPageNumber +
                ".";

        }
        public override string formatLibMed()
        {
            return getLastFiMiNoCommaNoDot() + ". " + getAsTyped() + ". " + JournalName + "." + getYear() +
                "; " + VolumeNumber + ":" + BeginingPageNumber + "-" + EndingPageNumber + ".";
        } 
    }
}
