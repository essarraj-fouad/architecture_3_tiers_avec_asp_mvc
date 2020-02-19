using StudentsManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.DAL
{
    public class StudentDAO
    {
        private static List<Student> _Data;

        static StudentDAO()
        {
            _Data = new List<Student>();
            _Data.Add(new Student(1, "Madani", "Ali"));
            _Data.Add(new Student(1, "Chami", "Mouad"));
        }

        public List<Student> FindAll()
        {
            return _Data;
        }

        public int Insert(Student student)
        {
            _Data.Add(student);
            return 1;
        }
    }
}
