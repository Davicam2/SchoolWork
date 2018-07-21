using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cameron Davis
//CS 1182
//Validates user input in refrence to a date style input and creates a good base format for dates to be used 
// in any output.
namespace ReferenceAccess
{
    public class Date
    {
        
        int _day;        
        int _month;
        string _monthName;
        int _year;

        /// <summary>
        /// entry point for day txtboxValue, validates formats and returns and returns
        /// </summary>
        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                 _day = value;                                                 
                if (_day < 1 || _day > 31)
                    {
                        _day = 0;
                    }
                
               
            }
        }

        /// <summary>
        /// entry point for month txtboxValue, validates formats and returns
        /// </summary>
        public int Month
        {            
            get
            {
                return _month;
            }
            set
            {
                _month = value;
                _day = Day;
                if (_month == 0)
                {
                    _month = 0;
                }
                else if (_month < 1 || _month > 12)
                {
                    _month = 0;
                }
                else
                {
                    switch (_month)
                    {
                        case 1:
                                if (_day > 31)
                                {
                                    Day = 0;
                                }
                                break;
                        case 2:
                                if (_day > 1 && _day < 29)
                                {
                                    Day = _day;
                                }
                                else if (_day == 29)
                                {
                                    validateLeapYear();
                                }
                                else
                                {
                                    Day = 0;
                                }                            
                                break;
                        case 3:
                                if (_day > 31)
                                {
                                    Day = 0;
                                }
                                break;
                        case 4:                            
                                if (_day > 30)
                                {
                                    Day = 0;
                                }
                                break;
                        case 5:
                                if (_day > 31)
                                {
                                    Day = 0; 
                                }
                                break;
                        case 6:
                                if (_day > 30)
                                {
                                    Day = 0;
                                }
                                break;
                        case 7:
                                if (_day > 31)
                                {
                                    Day = 0;
                                }
                                break;
                        case 8:
                                if (_day > 31)
                                {
                                    Day = 0;
                                }
                                break;
                        case 9:
                                if (_day > 30)
                                {
                                    Day = 0;
                                }
                                break;
                        case 10:
                                if (_day > 31)
                                {
                                    Day = 0;
                                }
                                break;
                        case 11:
                                if(_day > 30)
                                {
                                    Day = 0;
                                }
                                break;
                        case 12:
                                if (_day > 31)
                                {
                                    Day = 0;
                                }
                                break;                            
                    }
                }
                string monthName = _month.ToString();
                MonthName = monthName;
                
            }
        }

        /// <summary>
        /// takes value from Month property and equates it to the string equivilant.
        /// </summary>
        public string MonthName
        {
            get
            {
                return _monthName;
            }
            set
            {
                _monthName = value;
                string[] monthName ;
                if (Month == 0)
                {
                    _monthName = "";
                }
                else if (Month < 1 || Month > 12)
                {
                    _monthName = "";
                }
                else
                {
                    monthName = new string[12] {"January", "February","March", "April","May","June", "July", 
                                            "August","September", "October","November", "December"};
                    _monthName = monthName[Month -1];
                }
                                              
            }
        }

        /// <summary>
        /// entry point for year txtboxValue, validates formats and returns
        /// </summary>
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                
            }
        }
        
        /// <summary>
        /// when called it validates for a leap year situation between the day and month values.
        /// </summary>
        /// <returns></returns>
        public int validateLeapYear()
        {
            if (Day == 29 && _month == 2)
            {                
                int _leapYear = Year;
                if ((_leapYear % 4 == 0 && _leapYear % 100 != 0) || (_leapYear % 400 == 0))
                {
                    return Day;
                }
                return 0;
            } return Day;
        }
    }
}
