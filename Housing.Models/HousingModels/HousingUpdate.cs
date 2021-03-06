﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Housing_RedBadgeMVC.Data.Housing;

namespace Housing_RedBadgeMVC.Models.HousingModels
{
    public class HousingUpdate
    {
        public int HousingId { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public int UnitsAvailable { get; set; }

        public Voucher AcceptVoucher { get; set; }

        public Section SectionType { get; set; }

        public byte[] Image { get; set; }
    }
}
