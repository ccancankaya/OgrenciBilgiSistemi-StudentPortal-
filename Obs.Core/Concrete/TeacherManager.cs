using Obs.Business.Abstract;
using Obs.DataAccess.Abstract;
using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public void Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
        }

        public void Delete(int teacherId)
        {
            _teacherDal.Delete(new Teacher { TeacherId = teacherId });
        }

        public List<Teacher> GetAll()
        {
            return _teacherDal.GetList();
        }

        public Teacher GetById(int teacherId)
        {
            return _teacherDal.Get();
        }

        public List<Teacher> GetByProgram(int programId)
        {
            return _teacherDal.GetList(t => t.ProgramId == programId);
        }

        public void Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
        }
    }
}
