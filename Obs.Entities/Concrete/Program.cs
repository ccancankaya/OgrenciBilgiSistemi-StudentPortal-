using Obs.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Obs.Entities.Concrete
{
    public class Program : IEntity
    {
        [Key]
        public int ProgramId { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string ProgramName { get; set; }
     
    }
}
