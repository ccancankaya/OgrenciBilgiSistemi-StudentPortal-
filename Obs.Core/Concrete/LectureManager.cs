using Obs.Business.Abstract;
using Obs.DataAccess.Abstract;
using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Concrete
{
    public class LectureManager : ILectureService
    {
        private ILectureDal _lectureDal;

        public LectureManager(ILectureDal lectureDal)
        {
            _lectureDal = lectureDal;
        }

        public void Add(Lecture lecture)
        {
            _lectureDal.Add(lecture);
        }

        public void Delete(int lectureId)
        {
            _lectureDal.Delete(new Lecture { LectureId = lectureId });
        }

        public List<Lecture> GetAll()
        {
            return _lectureDal.GetList();
        }

        public List<Lecture> GetByFacultyId(int facultyId)
        {
            return _lectureDal.GetList(l => l.FacultyId == facultyId);
        }

        public Lecture GetById(int lectureId)
        {
            return _lectureDal.Get(l => l.LectureId == lectureId);
        }

        public List<Lecture> GetByProgramId(int programId)
        {
            return _lectureDal.GetList(l => l.ProgramId == programId);
        }

        public void Update(Lecture lecture)
        {
            _lectureDal.Update(lecture);
        }
    }
}
