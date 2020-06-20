using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }
        [Display(Name = "Tour Title")]
        public string TourTitle { get; set; }
        [Display(Name = "Tours Start At")]
        [DataType(DataType.Date)]
        public DateTime ToursStartAt { get; set; }
        [Display(Name = "Tours End At")]
        [DataType(DataType.Date)]
        public DateTime ToursEndAt { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}