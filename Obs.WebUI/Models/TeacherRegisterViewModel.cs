using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Obs.WebUI.Models
{
    public class TeacherRegisterViewModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
