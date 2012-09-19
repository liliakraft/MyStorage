﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class UserDetailsViewModel
    {
        [DisplayName("Name: ")]
        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Category: ")]
        public string Category { get; set; }
    }
}