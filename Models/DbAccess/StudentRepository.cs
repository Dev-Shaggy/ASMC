using System;
using System.Collections.Generic;
using AdvancedSchoolManagment.Models.Data;

namespace AdvancedSchoolManagment.Models.DbAccess
{
    public class StudentRepository : IStudentDAL
    {

        public StudentRepository(){
           
        }

        public void create(StudentDTO student)
        {
            throw new NotImplementedException();
        }

        public StudentDTO delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public StudentDTO get(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<StudentDTO> get()
        {
            throw new NotImplementedException();
        }

        public StudentDTO update(StudentDTO student)
        {
            throw new NotImplementedException();
        }
    }
}
