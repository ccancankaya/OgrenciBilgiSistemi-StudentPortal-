using Obs.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Obs.Entities.Concrete
{
    public class Student : IEntity
    {
        [Key]
        public int StudentNumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [Range(11, 11, ErrorMessage = "Lütfen 11 karakter giriniz")]
        public char TcNo { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [Range(11, 11, ErrorMessage = "Lütfen geçerli bir telefon girin")]
        public char PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen geçerli bir mail adresi girin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string FacultyName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string ProgramName { get; set; }
    }
}
 