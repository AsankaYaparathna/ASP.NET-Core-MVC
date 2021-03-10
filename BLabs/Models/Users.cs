using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BLabs.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("password",ErrorMessage ="Password not match..!")]
        public string ConfirmPassword { get; set; }

        [NotMapped]
        public bool RememberMe { get; set; }
    }
}
