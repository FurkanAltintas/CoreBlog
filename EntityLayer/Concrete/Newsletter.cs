﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Newsletter
    {
        public Newsletter()
        {
            CreateDate = DateTime.Now;
        }
        [Key]
        public int NewsletterId { get; set; }
        public string Mail { get; set; }
        public DateTime CreateDate { get; set; }
    }
}