using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_firstname_lastname_SLS
{
    public class Student : Person
    {
        private string _studentId;

        /// <summary>
        /// Initializes a student object with fill-ins for personal information (constructor)
        /// </summary>
        public Student()
        : base("John", "Doe", "321 school drive", "111-222-3333", "W0", 3)
        {
            StudentId = "S123";
        }

        public Student(string fName, string lName, string addy, string social, string wnum, string sId)
        : base(fName, lName, addy, social, wnum, 3)
        {
            StudentId = sId;
        }



        public string StudentId
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value[0] == 'E')
                    {
                        _studentId = value;
                    }
                }
            }
            get
            {
                if (!string.IsNullOrEmpty(_studentId))
                {
                    return _studentId;
                }
                else
                {
                    return "No Student Id is Set";
                }
            }
        }
    }
}
        
   
