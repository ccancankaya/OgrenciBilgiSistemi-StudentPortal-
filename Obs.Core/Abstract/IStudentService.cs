using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        List<Student> GetByProgram(string programName);
        List<Student> GetByFaculty(string facultyName);
        void Add(Student student);
        void Update(Student student);
        void Delete(int studentNumber);
        Student GetByNumber(int studentNumber);




    }
}
