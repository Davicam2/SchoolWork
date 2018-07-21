using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cameron Davis 
//CS 1182
//Chapter Class acts as data access for the ChapterForm.
namespace ReferenceAccess

{
    public class Chapter : Book
    {
         //string _publisher = "";
         List<Name> _editors = new List<Name>();
         string _state = "";
         string _country = "";
         int _beginPageNum = 0;
         int _endPageNum = 0;
         string _Ctitle = "";
         //Title myTitle = new Title();
        
        
        /// <summary>
         /// adds editor to the list of editors.
         /// </summary>
         /// <param name="editor"></param>
         public void addEditor(string firstName, string middleName, string lastName)
         {
            Name editorName = new Name();
             editorName.First = firstName;
             editorName.Middle = middleName;
             editorName.Last = lastName;


             _editors.Add(editorName);
             _editors.Sort();
         }

         public string getEditorNames()
         {
             string thisName = "";
             foreach (Name name in _editors)
             {
                 thisName += name.First + " " + name.MiddleInitial + " " + name.Last + "\r\n";
             }
             return thisName;
         }
         /// <summary>
         ///  the object to be called by the form class to output a name in the format Last First Middle initail.
         /// </summary>
         /// <returns></returns>
         public string getELastFirstMi()
         {
             string thisName = "";
             foreach (Name names in _editors)
             {
                 thisName += names.getLastFirstMi();
                 if (_editors.Count() >= 2 && names == _editors.ElementAt(0) && _editors.Count() < 3)
                 {
                     thisName += " and ";
                 }
                 if (_editors.Count() >= 3)
                 {
                     if (names != _editors.ElementAt(_editors.Count() - 1) &&
                         names != _editors.ElementAt(_editors.Count() - 2))
                     {
                         thisName += ", ";
                     }
                     if (names == _editors.ElementAt(_editors.Count() - 1))
                     {
                         thisName += " and ";
                     }
                 }
             }
             return thisName;
         }

         /// <summary>
         /// outputs names in the list in last, first initial, middle initial.
         /// </summary>
         /// <returns></returns>
         public string getELastFiMi()
         {
             string thisName = "";
             foreach (Name names in _editors)
             {
                 thisName += names.getLastFiMi();
                 if (_editors.Count() >= 2 && names == _editors.ElementAt(0) && _editors.Count() < 3)
                 {
                     thisName += " and ";
                 }
                 if (_editors.Count() >= 3)
                 {
                     if (names != _editors.ElementAt(_editors.Count() - 1) &&
                         names != _editors.ElementAt(_editors.Count() - 2))
                     {
                         thisName += ", ";
                     }
                     if (names == _editors.ElementAt(_editors.Count() - 2))
                     {
                         thisName += " and ";
                     }
                 }
             }
             return thisName;
         }

         /// <summary>
         /// returns the first obj in _listOfNames as last, first inital, middle initial, and all subsequent
         /// objs as first name, middle initial, last name.
         /// </summary>
         /// <returns></returns>
         public string getELastFiMi_FirstMiLast()
         {
             string thisName = "";
             foreach (Name names in _editors)
             {
                 if (names == _editors[0])
                 {
                     thisName += names.getLastFiMi();
                 }
                 if (_editors.Count() >= 2 && names == _editors.ElementAt(0) && _editors.Count() < 3)
                 {
                     thisName += " and ";
                     thisName += names.getFirstMiLast();
                 }
                 if (_editors.Count() >= 3)
                 {
                     if (names != _editors.ElementAt(_editors.Count() - 1) &&
                         names == _editors.ElementAt(_editors.Count() - 2))
                     {
                         thisName += ", ";
                         thisName += names.getFirstMiLast();
                     }
                     if (names == _editors.ElementAt(_editors.Count() - 1))
                     {
                         thisName += " and ";
                         thisName += names.getFirstMiLast();
                     }
                 }
             }
             return thisName;
         }

         /// <summary>
         /// returns the first obj in _listOfNames as last name, first name, middle initial, and all subsequent 
         /// objs as first name, middle initial, last name.
         /// </summary>
         /// <returns></returns>
         public string getELastFirstMi_FirstMiLast()
         {
             string thisName = "";
             foreach (Name names in _editors)
             {
                 if (names == _editors[0])
                 {
                     thisName += names.getLastFirstMi();
                 }
                 else
                 {
                     thisName += names.getFirstMiLast();
                     if (_editors.Count() >= 2 && names == _editors.ElementAt(0) && _editors.Count() < 3)
                     {
                         thisName += " and ";
                     }
                     if (_editors.Count() >= 3)
                     {
                         if (names != _editors.ElementAt(_editors.Count() - 1) &&
                             names != _editors.ElementAt(_editors.Count() - 2))
                         {
                             thisName += ", ";
                         }
                         if (names == _editors.ElementAt(_editors.Count() - 2))
                         {
                             thisName += " and ";
                         }
                     }
                 }
             }
             return thisName;
         }

         /// <summary>
         /// returns all objs in _listOfNames as last name, first initial, middile initial, no punctuation, with commas between
         /// objs, and an and at the end.
         /// </summary>
         /// <returns></returns>
         public string getELastFiMiNoCommaNoDot()
         {
             string thisName = "";
             foreach (Name names in _editors)
             {
                 thisName += names.getLastFiMi();
                 if (names != _editors.Last())
                 {
                     thisName += ", ";
                 }
             }
             return thisName;
         }

         /// <summary>
         /// returns objs in _listOfNames as first initial, middle initial, last name with commas between.
         /// </summary>
         /// <returns></returns>
         public string getEFiMiLast()
         {
             string thisName = "";
             foreach (Name names in _editors)
             {
                 thisName += names.getFiMiLast();
                 if (_editors.Count() >= 2 && names == _editors.ElementAt(0) && _editors.Count() < 3)
                 {
                     thisName += " and ";
                 }
                 if (_editors.Count() >= 3)
                 {
                     if (names != _editors.ElementAt(_editors.Count() - 1) &&
                         names != _editors.ElementAt(_editors.Count() - 2))
                     {
                         thisName += ", ";
                     }
                     if (names == _editors.ElementAt(_editors.Count() - 2))
                     {
                         thisName += " and ";
                     }
                 }
             }
             return thisName;
         }

         /// <summary>
         /// returns objs in _listOfNames as first name, middle initial, last name with commas and an and.
         /// </summary>
         /// <returns></returns>
         public string getEFirstMiLast()
         {
             string thisName = "";
             foreach (Name names in _editors)
             {
                 thisName += names.getFirstMiLast();
                 if (_editors.Count() >= 2 && names == _editors.ElementAt(0) && _editors.Count() < 3)
                 {
                     thisName += " and ";
                 }
                 if (_editors.Count() >= 3)
                 {
                     if (names != _editors.ElementAt(_editors.Count() - 1) &&
                         names != _editors.ElementAt(_editors.Count() - 2))
                     {
                         thisName += ", ";
                     }
                     if (names == _editors.ElementAt(_editors.Count() - 2))
                     {
                         thisName += " and ";
                     }
                 }
             }
             return thisName;
         }
        
        /// <summary>
        /// returns the publisher of item in question
        /// </summary>
        //public string BookPublisher
        //{
        //    get
        //    {
        //        return _publisher;
        //    }
        //    set
        //    {
        //        _publisher = value;

        //    }
        //}
       
        /// <summary>
        /// prop for publiher state.
        /// </summary>
        public string PublisherState
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        /// <summary>
        /// prop for publisher country.
        /// </summary>
        public string PublisherCountry
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
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
        public string chapterTitle
        {
            get
            {
                
                return _Ctitle;
            }
            set
            {
                _Ctitle = value;
                myTitle.AsTyped = _Ctitle;
                _Ctitle = myTitle.AsTyped;

            }

        }


        public override string formatMLA()
        {
            return getLastFirstMi_FirstMiLast() + ". '\u0022'" + chapterTitle + "'\u0022'. " + getAsTyped() + ", " +
                "Eds. " + getEFirstMiLast() + ". " + City + ", " + PublisherState + ": " +
                BookPublisher + ", " +  getYear() + ", " + BeginingPageNumber + "-" + EndingPageNumber + "." ;
        }
        public override string formatAPA()
        {
            return getLastFiMi() + ". (" + getYear() + "). " + chapterTitle + ". In " + getEFiMiLast() +
                " (Eds.), " + getAsTyped() + "(pp. " + BeginingPageNumber + "-" + EndingPageNumber +
                "). " + City + ", " + PublisherState + ": " + BookPublisher + ".";
        }
        public override string formatLibMed()
        {
            return getLastFiMi() + ". " + chapterTitle + "In. " + getELastFiMi() + ", Editors." +
                getAsTyped() + ". " + City + ": " + BookPublisher + "; " + getYear() + ". P." +
                BeginingPageNumber + "-" + EndingPageNumber + ".";
        }

       

       

       
    }
}
