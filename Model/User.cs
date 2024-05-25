﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autoberles.Model {
    public class User {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "A felhasználónév kötelező!")]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "A jelszó kötelező!")]
        public string Password { get; set; }
        public string Role { get; set; } = "User";

    }
}
