using Obs.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Obs.Entities.Concrete
{
    public class Faculty:IEntity
    {
        [Key]
        public int FacultyId { get; set; }

        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string FacultyName { get; set; }

    }
}
