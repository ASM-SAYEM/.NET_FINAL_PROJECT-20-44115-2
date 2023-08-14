﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ServiceProviderDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string shortDescriprtion { get; set; }
        [Required]
        public DateTime Date { get; set; }
       
        public string AssignedBy { get; set; }

        public string FeedbackBy { get; set; }

    }
}
