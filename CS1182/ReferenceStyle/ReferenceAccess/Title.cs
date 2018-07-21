using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cameron Davis
//CS 1182
//Creates an object that validates and creates a good base format for title inputs from the user.
//
namespace ReferenceAccess
{
    public class Title
    {
        string _title;
        /// <summary>
        /// property creats a string and is the access point for all other methods in this class to the user input.
        /// </summary>
        public string AsTyped
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                if (_title == "")
                {
                    _title = null;
                }
                if (_title != null)
                {
                    _title.Trim();

                    if (_title.ElementAt(0) < 'A' || _title.ElementAt(0) > 'z')
                    {
                        _title = null;
                    }
                }
                
            }
        }

        /// <summary>
        /// Method creates a string array out of the elements recieved from the AsTyped proprty
        /// and capitalizes all the strings unless the first element of each string is a number.
        /// </summary>
        /// <returns></returns>
        public string allCaps()
        {
            string title1 = "";
            _title = AsTyped;

            if (_title != null)
            {            
                
                string[] title = _title.Split(null, '-');
                int index = title.Length;
                for (int i = 0; i < index; i++)
                {
                    string[] noCaps = new string[]{"an"};                    

                    if (title[i].ElementAt(0) >= 'A' && title[i].ElementAt(0) <= 'z')
                    {
                        if(noCaps.Contains(title[i]))
                        {
                            title1 += title[i].ToLower();
                        }
                        else
                            title1 += title[i].ElementAt(0).ToString().ToUpper() + title[i].Substring(1).ToLower() ;                        
                    }        
            
                }
            }
                return title1;
            
        }

        /// <summary>
        /// Method takes te value in AsTyped and capitalizes the first element in the string array.
        /// </summary>
        /// <returns></returns>
        public string firstWordCap()
        {
            string title1 = "";
            _title = AsTyped;
            if (_title != null)
            {
                if (_title.ElementAt(0) >= '0' && _title.ElementAt(0) <= '9')
                {
                    title1 = _title + " ";
                }
                if (_title.ElementAt(0) >= 'A' && _title.ElementAt(0) <= 'z')
                {
                    title1 += _title.ElementAt(0).ToString().ToUpper() + _title.Substring(1).ToLower() + " ";
                }
            }
            return title1;
        }

        /// <summary>
        /// Method Takes the Value from AsTyped and makes all elements LowerCase.
        /// </summary>
        /// <returns></returns>
        public string allLower()
        {
            string title1 = "";
            _title = AsTyped;

            if (_title != null)
            {
                string[] title = _title.Split(null, '-');
                int index = title.Length;
                for (int i = 0; i < index; i++)
                {
                    if (title[i].ElementAt(0) >= '0' && title[i].ElementAt(0) <= '9')
                    {
                        title1 += title + " ";
                    }
                    if (title[i].ElementAt(0) >= 'A' && title[i].ElementAt(0) <= 'z')
                    {
                        title1 += title[i].Substring(0).ToLower() + " ";
                    }
                }
            }
            return title1;
        }
        

          
    }
}
