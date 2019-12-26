using Obs.Business.Abstract;
using Obs.DataAccess.Abstract;
using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Delete(int studentNumber)
        {
            _studentDal.Delete(new Student { StudentNumber = studentNumber });
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetList();
        }

        public List<Student> GetByFaculty(string facultyName)
        {
            return _studentDal.GetList(s => s.FacultyName == facultyName);
        }

     

        public Student GetByNumber(int studentNumber)
        {
            return _studentDal.Get(s => s.StudentNumber == studentNumber);
        }

        public List<Student> GetByProgram(string programName)
        {
            return _studentDal.GetList(s => s.ProgramName == programName);
        }

  

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }
    }
}
