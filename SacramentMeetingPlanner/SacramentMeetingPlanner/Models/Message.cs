using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Message
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime DateOfMeeting { get; set; }

        [Display(Name = "Opening Prayer")]
        [Required(ErrorMessage = "Enter Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Conducting")]
        [Required(ErrorMessage = "Enter Conducting Leader")]
        public string ConductingLeader { get; set; }

        [Display(Name = "Opening Hymn")]
        [Required(ErrorMessage = "Enter Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [Required(ErrorMessage = "Enter Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        [Required(ErrorMessage = "Enter Closing Hymn")]
        public string ClosingHymn { get; set; }


        [Display(Name = "Closing Prayer")]
        [Required(ErrorMessage = "Enter Closing Prayer")]
        public string ClosingPrayer { get; set; }

        public virtual Speakers Speakers { get; set; }
    }
}