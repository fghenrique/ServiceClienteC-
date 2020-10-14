﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Cep
    {
        [Required]
        [MaxLength(9, ErrorMessage = "Ceptem que ser digitado no formato 70000-000 ")]
        [MinLength(9, ErrorMessage = "Ceptem que ser digitado no formato 70000-000 ")]
        public string Codigo { get; set; }
    }
}