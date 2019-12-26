using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Abstract
{
    public interface ILectureService
    {
        List<Lecture> GetAll();

        List<Lecture> GetByFacultyId(int facultyId);

        List<Lecture> GetByProgramId(int programId);

        void Add(Lecture lecture);
        void Update(Lecture lecture);
        void Delete(int lectureId);

        Lecture GetById(int lectureId);



    }
}
