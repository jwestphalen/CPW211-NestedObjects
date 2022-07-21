using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace NestedObjects
{
    /// <summary>
    /// Represents an individaul college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Legal first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Legal last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }
        /// <summary>
        /// Student Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// The student's assigned advisor
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }

    }
}
