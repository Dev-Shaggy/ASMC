using System.Collections.Generic;
using System;
using AdvancedSchoolManagment.Models.Data;
using AdvancedSchoolManagment.Models.ViewModels;

namespace AdvancedSchoolManagment.Models.DbAccess
{
    public interface IStudentDAL
    {
        StudentDTO get(Guid id);
        ICollection<StudentDTO> get();
        StudentDTO update(StudentDTO student);
        StudentDTO delete(Guid id);
        void create(StudentDTO student);
    }
}
