using Microsoft.AspNetCore.Mvc;
﻿using System.ComponentModel.DataAnnotations;

namespace TODO_Correction.ViewModels
{
    public class AuthVM
    {

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string login { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [DataType(DataType.Password)]
       // [RegularExpression(@"[A-Za-z]{3,}[0-9]{1,}", ErrorMessage = "mot de passe faible")]
        public string password { get; set; }

        [Required(ErrorMessage = "La confirmation est obligatoire")]
        [Compare("password", ErrorMessage = "les mots de passes doivent être identiques")]
        public string confirmation { get; set; }
    }
}