using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Entities
{
    public class Student
    {
        public Student()
        {

        }

        public Student(int id, string firstname, string lastname)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public int Id { get; set; }
        public String FirstName { get; set; }
        public String  LastName { get; set; }
    }
}
