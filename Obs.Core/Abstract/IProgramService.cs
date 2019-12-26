using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.Business.Abstract
{
    public interface IProgramService
    {
        List<Program> GetAll();



        void Add(Program program);
        void Update(Program program);
        void Delete(int programId);
        Program GetById(int programId);
    }
}
