﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("Pictures")]
    public class Picture
    {
        public Picture()
        {
        }

        public int PictureId { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        public int ProductId { get; set; }

        public virtual Product Products { get; set; }
    }
}
