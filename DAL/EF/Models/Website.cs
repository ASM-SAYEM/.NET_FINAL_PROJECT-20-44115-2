using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Website
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }


        [ForeignKey("Client")]
        public string FeedbackBy { get; set; }

        public DateTime Date { get; set; }

        public virtual Client Client { get; set; }
    }
}
