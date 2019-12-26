using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Obs.WebUI.Models
{
    public class StudentRegisterViewModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        //[Remote(action: "VerifyNumber", controller: "StudentAccount",HttpMethod ="POST",ErrorMessage ="Öğrenci bulunamadı!")]
        public int StudentNumber { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen sistemde kayıtlı olan mail adresi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan boş bıralıaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
