using StudentsManagement.DAL;
using StudentsManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.BLL
{
    public class StudentBLO
    {
        private StudentDAO _StudentDAO { set; get; }

        public StudentBLO()
        {
            _StudentDAO = new StudentDAO();
        }

        public List<Student> FindAll()
        {
            return _StudentDAO.FindAll();
        }

        public int Save(Student student)
        {
            if(student.Id == 0)
            {
               return   _StudentDAO.Insert(student);
            }
            else
            {
                // Update;
                throw new NotImplementedException();
            }
          
        }
    }
}
