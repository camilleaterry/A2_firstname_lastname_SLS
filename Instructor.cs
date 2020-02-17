using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_firstname_lastname_SLS
{
    public class Instructor : Person
    {
        private string _instructorId;

        public Instructor()
        : base("John", "Doe", "1234 fake street", "111-222-3333", "w0", 5)
        {

            InstructorId = "E321";
        }
        public Instructor(string fName, string lName, string address, string SSN, string wnum, string instructorId)
        : base(fName, lName, address, SSN, wnum, 5)
        {

            InstructorId = instructorId;
        }
        public string InstructorId
        {
            get
            {
                if (!string.IsNullOrEmpty(_instructorId))
                {
                    return _instructorId;
                }
                else
                {
                    return "No Instructor Id is Set";
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value[0] == 'E')
                    {
                        _instructorId = value;
                    }
                }
            }

        }
    }
}
