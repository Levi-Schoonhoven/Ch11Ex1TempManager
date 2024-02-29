using System;
using System.ComponentModel.DataAnnotations;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a Date.(DD/MM/YYYY)")]
        [Range(typeof(DateTime), "1/1/1800", "12/31/9999")]
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "Please enter a Low")]
        [Range(-200, 200)]
        public double? Low { get; set; }
        [Required(ErrorMessage = "Please enter a High")]
        [Range(-200, 200)]
        public double? High { get; set; }
    }
}
