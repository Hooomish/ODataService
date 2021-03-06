﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    public class Book
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public String Name { get; set; }
        public int Year { get; set; }
    }
}