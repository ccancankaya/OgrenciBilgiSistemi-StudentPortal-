using Obs.Core.DataAccess.EntityFramework;
using Obs.DataAccess.Abstract;
using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obs.DataAccess.Concrete.EntityFramework
{
    public class EfFacultyDal : EfEntityRepositoryBase<Faculty, ObsContext>, IFacultyDal
    {
    }
}
