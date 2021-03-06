﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_RedBadgeMVC.Models.RatingModels
{
   public class RatingCreate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int HousingId { get; set; }

        public string ApplicantId { get; set; }

        [Required]
        public decimal Rating { get; set; }

        public DateTime Posted { get; set; }
    }
}
