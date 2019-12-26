using Obs.Business.Abstract;
using Obs.DataAccess.Abstract;
using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Concrete
{
    public class FacultyManager : IFacultyService
    {
        private IFacultyDal _facultyDal;

        public FacultyManager(IFacultyDal facultyDal)
        {
            _facultyDal = facultyDal;
        }


        public void Add(Faculty faculty)
        {
            _facultyDal.Add(faculty);
        }

        public void Delete(int facultyId)
        {
            _facultyDal.Delete(new Faculty { FacultyId = facultyId });
        }

        public List<Faculty> GetAll()
        {
            return _facultyDal.GetList();
        }

        public Faculty GetById(int faculytId)
        {
            return _facultyDal.Get(f => f.FacultyId == faculytId);
        }

        public void Update(Faculty faculty)
        {
            _facultyDal.Update(faculty);
        }
    }
}
