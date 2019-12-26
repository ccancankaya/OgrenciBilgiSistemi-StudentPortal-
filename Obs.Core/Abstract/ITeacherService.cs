using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Abstract
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();

        List<Teacher> GetByProgram(int programId);

        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int teacherId);

        Teacher GetById(int teacherId);

    }
}
