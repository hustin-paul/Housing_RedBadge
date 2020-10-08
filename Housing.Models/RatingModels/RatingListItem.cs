﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_RedBadgeMVC.Models.RatingModels
{
    public class RatingListItem
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Housing ID")]
        public int HousingId { get; set; }

        [Display(Name = "User")]
        public string ApplicantId { get; set; }

        [Display(Name = "Rating")]
        public decimal Rating { get; set; }
    }
}
