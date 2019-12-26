using Obs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obs.WebUI.Models
{
    public class StudentAddViewModel
    {
        public List<Faculty> Faculties { get; set; }
        public List<Program> Programs { get; set; }
        public Student Student { get; set; }

    }
}
