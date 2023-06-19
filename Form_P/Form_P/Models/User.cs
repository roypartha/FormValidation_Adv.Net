using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form_P.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please provide your name")]
       // [MaxLength(99)]
       // [RegularExpression("^[a-zA-Z .]*$", ErrorMessage = "Username can only contain alphabets, spaces, and dots")]
       
        [NameValidation]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide your username")]
        [RegularExpression("^[!-}]*$", ErrorMessage = "Username can only contain alphabets, special characters, and numbers")]
        [MaxLength(15)]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
       
        [Required]
        public string[] Profession { get; set; }
        [Required]
        [BirthdateValidation]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Please provide the ID")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]*$", ErrorMessage = "ID Format: XX-XXXXX-X")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Please provide the Email")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]@student.aiub.edu*$", ErrorMessage = "ID Format: XX-XXXXX-X@student.aiub.edu")]
        public string Email { get; set; }

    }
}