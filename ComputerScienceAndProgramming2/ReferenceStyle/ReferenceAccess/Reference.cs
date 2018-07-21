using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cameron Davis 
//CS 1182
//Accessess the name, title, date classes, and acts as the access point for classes containing said field
//  data.
namespace ReferenceAccess
{
    public abstract class Reference : IFormatRefrence , IComparable<Reference>

    {        
        /// <summary>
        /// this chunk creates the class objects needed to manipulate the data entered into the system and 
        /// send the data to the appropriate fields to be validated and formated.
        /// </summary>
        public Date myDate = new Date();
        public Title myTitle = new Title();        
        public List<Name> _listOfNames = new List<Name>();         
        string _city = "";        
       

        /// <summary>
        /// sends user input for title to the title class.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public void enterTitle(string title)
        {
            
            if (title == "")
            {
                myTitle.AsTyped = "No title entered";
            }else
            myTitle.AsTyped = title;            
        }
        
        /// <summary>
        /// gives you the entered fields just as the user typed them, of type title
        /// </summary>
        /// <returns></returns>
        public string getAsTyped()
        {
            return myTitle.AsTyped;
        }
        
        /// <summary>
        /// returns the title as all capitalized words
        /// </summary>
        /// <returns></returns>
        public string getAllCaps()
        {
            return myTitle.allCaps();
        }

        /// <summary>
        /// returns the title with only the first word capitalized
        /// </summary>
        /// <returns></returns>
        public string getFirstWordCap()
        {
            return myTitle.firstWordCap();
        }

        /// <summary>
        /// returns the title with all lower case strings
        /// </summary>
        /// <returns></returns>
        public string getAllLower()
        {
            return myTitle.allLower();
        }

        /// <summary>
        /// sends the user input data for dd mm ccyy type input to the date handling class.
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public void enterDate(int day, int month, int year)
        {

            myDate.Day = day;
            myDate.Month = month;
            myDate.Year = year;            
        }
       
        public string getMoDayYear()
        {
            string thisDate = "";
            if (myDate.Month != 0)
            {
                thisDate += myDate.Month.ToString() + "/";
            }
            else
                thisDate += "No month entered /";
            if (myDate.Day != 0)
            {
                thisDate += myDate.Day.ToString() + "/";
            }
            else
                thisDate += "No day entered /";

            if (myDate.Year != 0)
            {
                thisDate += myDate.Year.ToString();
            }
            else
                thisDate += "No year entered /";
            return thisDate;
        }
        public string getMonthDayYear()
        {
            string thisDate = "";
            if (myDate.Month != 0)
            {
                thisDate += myDate.MonthName + " ";
            }else
                thisDate += "No month entered /";
            if (myDate.Day != 0)
            {
                thisDate += myDate.Day.ToString() + ", ";
            }else
                thisDate += "No day entered /";
            if (myDate.Year != 0)
            {
                thisDate += myDate.Year.ToString();
            }else
                thisDate += "No year entered /";
            return thisDate; 
        }
        public string getMoYear()
        {
            string thisDate = "";
            if (myDate.Month != 0)
            {
                thisDate += myDate.Month.ToString() + "/";
            }else
                thisDate += "No month entered /";
            if (myDate.Year != 0)
            {
                thisDate += myDate.Year.ToString();
            }else
                thisDate += "No year entered /";
            return thisDate;
        }
        public string getMonthYear()
        {
            string thisDate = "";
            if (myDate.Month != 0)
            {
                thisDate += myDate.MonthName + ", ";
            }else
                thisDate += "No month entered /";

            if (myDate.Year != 0)
            {
                thisDate += myDate.Year.ToString();
            }else
                thisDate += "No year entered /";
            return thisDate;
        }
        public string getYear()
        {            
            if (myDate.Year != 0)
            {
                return myDate.Year.ToString();
            }else
               return "No year entered /";            
        }


        /// <summary>
        /// gets the user input for author names, and adds Name objects with user data into a list of 
        /// Name objects.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public void enterNamesList(string firstName, string middleName, string lastName)
        {   


            Name myName = new Name();

            myName.First = firstName;
            myName.Middle = middleName;
            myName.Last = lastName;
            
            _listOfNames.Add(myName);
            _listOfNames.Sort();           
        }

        /// <summary>
        /// returns just the names input into the _listofnames
        /// </summary>
        /// <returns></returns>
        public string justName()
        {
            string thisName = "";
            foreach (Name names in _listOfNames)
            {
                thisName += names.First + " " + names.MiddleInitial + " " + names.Last + "\r\n";
                
            }
            return thisName;
        }       

        /// <summary>
        ///  the object to be called by the form class to output a name in the format Last First Middle initail.
        /// </summary>
        /// <returns></returns>
        public string getLastFirstMi()
        {                                                
            string thisName = "";
            foreach (Name names in _listOfNames)
            {                
                thisName += names.getLastFirstMi();
                if (_listOfNames.Count() >= 2 && names == _listOfNames.ElementAt(0) && _listOfNames.Count() < 3)
                {
                    thisName += " and ";
                }
                if (_listOfNames.Count() >= 3)
                {
                    if (names != _listOfNames.ElementAt(_listOfNames.Count() - 1) && 
                        names != _listOfNames.ElementAt(_listOfNames.Count() - 2))
                    {
                        thisName += ", ";
                    }
                    if (names == _listOfNames.ElementAt(_listOfNames.Count() - 1))
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
        public string getLastFiMi()
        {
            string thisName = "";
            foreach (Name names in _listOfNames)
            {
                thisName += names.getLastFiMi();
                if (_listOfNames.Count() >= 2 && names == _listOfNames.ElementAt(0) && _listOfNames.Count() < 3)
                {
                    thisName += " and ";
                }
                if (_listOfNames.Count() >= 3)
                {
                    if (names != _listOfNames.ElementAt(_listOfNames.Count() - 1) &&
                        names != _listOfNames.ElementAt(_listOfNames.Count() - 2))
                    {
                        thisName += ", ";
                    }
                    if (names == _listOfNames.ElementAt(_listOfNames.Count() - 2))
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
        public string getLastFiMi_FirstMiLast()
        {
            string thisName = "";
            foreach (Name names in _listOfNames)
            {
                if (names == _listOfNames[0])
                {
                    thisName += names.getLastFiMi();
                }
                else
                {
                    thisName += names.getFirstMiLast();


                    if (_listOfNames.Count() == 2 && names == _listOfNames.ElementAt(0) && _listOfNames.Count() < 3)
                    {
                        thisName += " and ";

                    }

                    if (_listOfNames.Count() >= 3)
                    {
                        if (names != _listOfNames.ElementAt(_listOfNames.Count() - 1) &&
                            names == _listOfNames.ElementAt(_listOfNames.Count() - 2))
                        {
                            thisName += ", ";
                            thisName += names.getFirstMiLast();
                        }
                        if (names == _listOfNames.ElementAt(_listOfNames.Count() - 1))
                        {
                            thisName += " and ";
                            thisName += names.getFirstMiLast();
                        }
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
        public string getLastFirstMi_FirstMiLast()
        {
            string thisName = "";
            foreach (Name names in _listOfNames)
            {
                if (names == _listOfNames[0])
                {
                    thisName += names.getLastFirstMi();
                }

                else
                {
                    thisName += names.getFirstMiLast();
                    if (_listOfNames.Count() >= 2 && names == _listOfNames.ElementAt(0) && _listOfNames.Count() < 3)
                    {
                        thisName += " and ";
                        
                    }
                    if (names == _listOfNames[1])
                {
                    thisName += names.getLastFiMi();
                }
                    if (_listOfNames.Count() >= 3)
                    {
                        if (names != _listOfNames.ElementAt(_listOfNames.Count() - 1) &&
                            names != _listOfNames.ElementAt(_listOfNames.Count() - 2))
                        {
                            thisName += ", ";
                        }
                        if (names == _listOfNames.ElementAt(_listOfNames.Count() - 2))
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
        public string getLastFiMiNoCommaNoDot()
        {
            string thisName = "";
            foreach (Name names in _listOfNames)
            {
                thisName += names.getLastFiMiNoCommaNoDot();
                if (names != _listOfNames.Last())
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
        public string getFiMiLast()
        {
            string thisName = "";
            foreach (Name names in _listOfNames)
            {
                thisName += names.getFiMiLast();
                if (_listOfNames.Count() >= 2 && names == _listOfNames.ElementAt(0) && _listOfNames.Count() < 3)
                {
                    thisName += " and ";
                }
                if (_listOfNames.Count() >= 3)
                {
                    if (names != _listOfNames.ElementAt(_listOfNames.Count() - 1) &&
                        names != _listOfNames.ElementAt(_listOfNames.Count() - 2))
                    {
                        thisName += ", ";
                    }
                    if (names == _listOfNames.ElementAt(_listOfNames.Count() - 2))
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
        public string getFirstMiLast()
        {
            string thisName = "";
            foreach (Name names in _listOfNames)
            {
                thisName += names.getFirstMiLast();
                if (_listOfNames.Count() >= 2 && names == _listOfNames.ElementAt(0) && _listOfNames.Count() < 3)
                {
                    thisName += " and ";
                }
                if (_listOfNames.Count() >= 3)
                {
                    if (names != _listOfNames.ElementAt(_listOfNames.Count() - 1) &&
                        names != _listOfNames.ElementAt(_listOfNames.Count() - 2))
                    {
                        thisName += ", ";
                    }
                    if (names == _listOfNames.ElementAt(_listOfNames.Count() - 2))
                    {
                        thisName += " and ";
                    }
                }
            }
            return thisName;
        }

        /// <summary>
        /// gets the city input for the output formats
        /// </summary>
        public string City
        {
            
            get
            {
                return _city;
            }
            set
            {
                 _city = value;
                 if (_city == "")
                 {
                     _city = null;
                 }
                 if (_city != null)
                 {
                     _city = _city.Trim().ElementAt(0).ToString().ToUpper() + _city.Substring(1).ToLower();
                 }
                

            }
            
        }      
        
        /// <summary>
        /// destroys all the list components.
        /// </summary>
        public void listOfNamesClear()
        {
            _listOfNames.Clear();
        }                      


        public virtual string formatMLA()
        {
            return null;
        }

        public virtual string formatAPA()
        {
            return null;
        }

        public virtual string formatLibMed()
        {
            return null;
        }

        public int CompareTo(Reference nextReference)
        {           
                return this.justName().ToString().CompareTo(nextReference.justName().ToString());            
        }

      

       

        

       
    }
}
