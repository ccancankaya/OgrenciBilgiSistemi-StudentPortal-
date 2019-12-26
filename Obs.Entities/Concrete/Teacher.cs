using Obs.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Obs.Entities.Concrete
{
    public class Teacher:IEntity
    {
        [Key]
        public int TeacherId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Lütfen geçerli bir mail adresi giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int FacultyId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int ProgramId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
