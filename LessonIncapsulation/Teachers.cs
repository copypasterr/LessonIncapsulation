using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonIncapsulation
{
    public class Teachers
    {
        public Teachers() { }

        public int ID { get; set; }

        public string Fullname { get; set; }

        public Subjects Subject { get; set; }

        public int HoursWorked { get; set; }

        public string PhoneNumber { get; set; }

        public int Experience { get; set; }
    }
}