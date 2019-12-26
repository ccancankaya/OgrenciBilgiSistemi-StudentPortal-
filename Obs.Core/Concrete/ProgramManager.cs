using Obs.Business.Abstract;
using Obs.DataAccess.Abstract;
using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Concrete
{
    public class ProgramManager : IProgramService
    {
        private IProgramDal _programDal;

        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }

        public void Add(Program program)
        {
            _programDal.Add(program);
        }

        public void Delete(int programId)
        {
            _programDal.Delete(new Program { ProgramId = programId });
        }

        public List<Program> GetAll()
        {
            return _programDal.GetList();
        }


        public Program GetById(int programId)
        {
            return _programDal.Get(p => p.ProgramId == programId);
        }

        public void Update(Program program)
        {
            _programDal.Update(program);
        }
    }
}
