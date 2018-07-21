using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cameron Davis 
//CS 1182
// Validates inputs based on a Name input system, formats for multiple output arrangements.
//

namespace ReferenceAccess
{
    public class Name : IComparable<Name>
    {
        private string _first;
        private string _firstInitial;
        private string _middle;
        private string _middleInitial;
        private string _last;
        private string _lastInitial;
                       
        /// <summary>
        /// entery point for first name txtboxValue, validates formats and returns
        /// </summary>
        public string First
        {
            
            get
            {
                return _first;
            }
            set
            {
                _first = value.Trim();
                bool firstNull = false;
                int spacedName = _first.IndexOf(" ");
                int hyphenedName = _first.IndexOf("-");
                
                for (int i = 0; i < _first.Length; i++)
                {
                    if (_first.ElementAt(i) >= '0' && _first.ElementAt(i) <= '9')
                    {
                        firstNull = true;
                        _first = "";
                    }                                            
                }

                if (firstNull == false)
                {

                    if (spacedName > 0)
                    {
                        string first = "";
                        foreach (string i in _first.Split(null,'-'))
                        { 
                            first += i.ElementAt(0).ToString().ToUpper()
                                        + i.Substring(1).ToLower() + " ";                            
                        }
                        _first = first.Trim();
                        FirstInitial = _first.ElementAt(0).ToString();
                        
                    }
                    else if (hyphenedName > 0)
                    {
                        string first = "";
                        foreach (string i in _first.Split(null, '-'))
                        {
                            first += i.ElementAt(0).ToString().ToUpper()
                                        + i.Substring(1).ToLower();
                            _first = first;
                        }
                        FirstInitial = _first.ElementAt(0).ToString();
                        
                    }
                    else if (_first == "")
                    {
                        _first = "";
                        FirstInitial = "";

                    }
                    else
                    {
                        _first = _first.ElementAt(0).ToString().ToUpper()
                        + _first.Substring(1).ToLower();
                        FirstInitial = _first.ElementAt(0).ToString();
                    }
                }
                
                          
            }
        }

        /// <summary>
        /// takes First property and createsan initial from it
        /// </summary>
        public string FirstInitial
        {
            get
            {
                return _firstInitial;
            }
            set
            {                
                 _firstInitial = value;                                                          
            }
        }

        /// <summary>
        /// entry point for Middle name txtboxValue, validates and formats, then returns
        /// </summary>
        public string Middle
        {
            get
            {
                return _middle;
            }
            set
            {
                bool midNull = false;
                _middle = value.Trim();
                int spacedName = _middle.IndexOf(" ");
                int hyphenedName = _middle.IndexOf("-");
                for (int i = 0; i < _middle.Length; i++)
                {
                    if (_middle.ElementAt(i) >= '0' && _middle.ElementAt(i) <= '9')
                    {
                        midNull = true;
                        _middle = "";
                    }
                }
                if (midNull == false)
                {                                        
                    for (int i = 0; i < _middle.Length; i++)
                    {
                        if (_middle.ElementAt(i) >= 0 && _middle.ElementAt(i) <= 9)
                        {
                            midNull = true;
                            _middle = "";
                        }
                    }

                    if (midNull == false)
                    {


                        if (spacedName > 0)
                        {

                            _middle = _middle.ElementAt(0).ToString().ToUpper()
                            + _middle.Substring(1, spacedName - 1).ToLower()
                            + _middle.ElementAt(spacedName + 1).ToString().ToUpper()
                            + _middle.Substring(spacedName + 2).ToLower();
                            MiddleInitial = _middle.ElementAt(0).ToString();
                        }
                        else if (hyphenedName > 0)
                        {
                            _middle = _middle.ElementAt(0).ToString().ToUpper()
                            + _middle.Substring(1, hyphenedName - 1).ToLower()
                            + _middle.ElementAt(hyphenedName + 1).ToString().ToUpper()
                            + _middle.Substring(hyphenedName + 2).ToLower();
                            MiddleInitial = _middle.ElementAt(0).ToString();
                        }
                        else if (_middle == "")
                        {
                            _middle = "";
                            MiddleInitial = "";
                        }
                        else
                        {
                            _middle = _middle.ElementAt(0).ToString().ToUpper()
                            + _middle.Substring(1).ToLower();
                            MiddleInitial = _middle.ElementAt(0).ToString();
                        }
                    }

                }
            }
            
        }

        /// <summary>
        /// takes value from Middle Property and creates a middle initial.
        /// </summary>
        public string MiddleInitial
        {            
            get
            {
                return _middleInitial;
            }
            set
            {
                _middleInitial = value;                                                         
            }
        }

        /// <summary>
        /// entry point for Last Name txtboxValue, validates and formatst, and returns.
        /// </summary>
        public string Last
        {
            get
            {
                return _last;
            }
            set
            {
                bool lastNull = false;
                _last = value.Trim();
                int spacedName = _last.IndexOf(" ");
                int hyphenedName = _last.IndexOf("-");


                for (int i = 0; i < _last.Length; i++)
                {
                    if (_last.ElementAt(i) >= '0' && _last.ElementAt(i) <= '9')
                    {
                        _last = "";
                        lastNull = true;
                    }
                }
                if (lastNull == false)
                {


                    if (spacedName > 0)
                    {
                        _last = _last.ElementAt(0).ToString().ToUpper()
                        + _last.Substring(1, spacedName - 1).ToLower()
                        + _last.ElementAt(spacedName + 1).ToString().ToUpper()
                        + _last.Substring(spacedName + 2).ToLower();
                        LastInitial = _last.ElementAt(0).ToString();
                    }
                    else if (hyphenedName > 0)
                    {
                        _last = _last.ElementAt(0).ToString().ToUpper()
                        + _last.Substring(1, hyphenedName - 1).ToLower()
                        + _last.ElementAt(hyphenedName + 1).ToString().ToUpper()
                        + _last.Substring(hyphenedName + 2).ToLower();
                        LastInitial = _last.ElementAt(0).ToString();
                    }
                    else if (_last == "")
                    {
                        _last = "";
                        LastInitial = "";
                    }
                    else
                    {
                        _last = _last.ElementAt(0).ToString().ToUpper()
                        + _last.Substring(1).ToLower();
                        LastInitial = _last.ElementAt(0).ToString();
                    }
                }
            }
        }

        /// <summary>
        /// takes value from Last Property already formated and allows a call for the last initial
        /// </summary>
        public string LastInitial
        {
            get
            {
                return _lastInitial;
            }
            set
            {
                
                _lastInitial = value;
                
            }
        }

        /// <summary>
        /// builds a string composed of first name, space, middle name, space, last name.
        /// </summary>
        /// <returns></returns>
        public string fullName()
        {           
            string name = First + " " + Middle + " " + Last;
            return name;
        }
                
       /// <summary>
       /// manual sorting algorithm, unfinnished, IComparable is easier 
       /// </summary>
       /// <returns></returns>
       // public string compareTo()
       // {
            
            

       //     for (int i = 0; i < listOfNames().Count(); i++)     //isolates each element in the list, allows access to each name.
       //     {                
       //         int currentIndex = listOfNames()[i].Split(null, '-').Count();// int of how many words are in each name.
       //         int nextIndex = listOfNames()[i +1].Split(null, '-').Count();

       //         string[] fiMiLaCurrent = new string[currentIndex];
       //         string[] fiMiLaNext = new string[nextIndex];
       //         fiMiLaCurrent = listOfNames()[i].Split(null, '-');// creates an array out of current name.
       //         fiMiLaNext = listOfNames()[i +1].Split(null, '-');

       //         int currentNameIndex = fiMiLaCurrent
       //         for (int j = 0; j < fiMiLaCurrent.ElementAt().Length; j++) // loops for each letter in 
       //         {                                       
       //             foreach (string s in fiMiLaCurrent) // allows manipulation of each word in each name.
       //             {                                                
       //                 string currentName = fiMiLaCurrent[j];
       //                 string nextName = listOfNames()[j + 1];
       //                 string tmp = nextName;
                        
       //                 if (currentName.ElementAt(0) == nextName.ElementAt(0))
       //                 {
       //                     if(firstName.ElementAt(0) ==  0);
       //                 }
       //             }
       //         }
                
       //     }
       //}

        /// <summary>
        /// compares the Name properties of Last and First Initial and sorts them in assending order.
        /// </summary>
        /// <param name="nextName"> the variable for the next object in the list</param>
        /// <returns></returns>
       public int CompareTo(Name nextName)
       {           
           if (this.Last == nextName.Last)
           {
               return this.First.CompareTo(nextName.First);
           }
           return this.Last.CompareTo(nextName.Last);            
        }

        /// <summary>
        /// returns "last, first M."
        /// </summary>
        /// <returns></returns>
       public string getLastFirstMi()
       {
           return Last + ", " + First + " " + MiddleInitial + ".";
       }

        /// <summary>
        /// returns "Last, F. M."
        /// </summary>
        /// <returns></returns>
       public string getLastFiMi()
       {
           return Last + ", " + FirstInitial + ". " + MiddleInitial + ".";
       }

       public string getLastFiMiNoCommaNoDot()
       {
           return Last + " " + FirstInitial  + MiddleInitial ;
       }
        /// <summary>
        /// returns "First M Last"
        /// </summary>
        /// <returns></returns>
       public string getFirstMiLast()
       {
           return First + " " + MiddleInitial + " " + Last;
       }

        /// <summary>
        /// returns "F M Last"
        /// </summary>
        /// <returns></returns>
       public string getFiMiLast()
       {
           return FirstInitial + " " + MiddleInitial + " " + Last;
       }
    }
}
