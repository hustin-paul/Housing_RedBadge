﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_RedBadgeMVC.Data
{
   public class SafetyRating
    {
        [Key]
        public int Id { get; set; }

        // Housing ID
        [ForeignKey(nameof(HousingAppId))]
        public int HousingId { get; set; }
        public virtual Housing HousingAppId { get; set; }

        // Application User ID
        [ForeignKey(nameof(ApplicantUser))]
        public string ApplicantId { get; set; }
        public virtual ApplicationUser ApplicantUser { get; set; }

        [Required]
        public decimal Rating { get; set; }

        public DateTime Posted { get; set; }
    }
}
