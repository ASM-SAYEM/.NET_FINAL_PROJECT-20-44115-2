﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class WebsiteDTO
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string FeedbackBy { get; set; }

        public DateTime Date { get; set; }

    }
}
