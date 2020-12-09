using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models

{
    public class Speakers
    {
        public int Id { get; set; }

        public string Speaker { get; set; }
        public string Subject { get; set; }
    }
}
