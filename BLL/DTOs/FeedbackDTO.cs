using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FeedbackDescription { get; set; }
        [Required]
        public int Star { get; set; }

        public DateTime Date { get; set; }
     
        public string FeedbackBy { get; set; }
        
        public int ServiceProviderId { get; set; }
    }
}
