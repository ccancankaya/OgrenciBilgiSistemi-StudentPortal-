using Obs.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Obs.Entities.Concrete
{
    public class Lecture : IEntity
    {
        [Key]
        public int LectureId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string LectureName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int Akts { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int Credit { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public float HourPerWeek { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int ProgramId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int FacultyId { get; set; }
    }
}
