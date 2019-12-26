using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Obs.WebUI.Models
{
    public class StudentLoginViewModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int StudentNumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Pssword { get; set; }

    }
}
