using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Abstract
{
    public interface IFacultyService
    {
        List<Faculty> GetAll();

        void Add(Faculty faculty);
        void Update(Faculty faculty);
        void Delete(int facultyId);

        Faculty GetById(int faculytId);

    }
}
