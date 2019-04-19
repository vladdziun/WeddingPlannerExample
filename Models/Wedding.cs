using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        [Required (ErrorMessage = "Title is required!")]
        [Display(Name = "Title")] 
        public string WeddingTitle { get; set; }
        [Required(ErrorMessage = "Time is required!")]
        public DateTime Time { get; set; }
        [Required(ErrorMessage = "Date is required!")]
        [Display(Name = "Date")]
        [DateInTheFuture]
        public DateTime WeddingDate { get; set; }
        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Duration is required!")]
        public int Duration { get; set; }
        [Required]
        [Display(Name = " ")] 
        public string TimeType { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public string CreatorName { get; set; }

        //nav
        public List<Association> Guests { get; set; }
    }
}