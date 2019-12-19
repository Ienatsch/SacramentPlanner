using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MeetingPlanner.Models
{
    public class Planner
    {
        public int PlannerID { get; set; }

        [Display(Name = "Ward/Branch")]
        [StringLength(60, MinimumLength = 3), Required]
        public string WardBranch { get; set; }
        
        [Display(Name= "Sabbath Day"), DataType(DataType.Date), Required]
        public DateTime SabbathDay { get; set;}

        [Display(Name = "Conducting")]
        [StringLength(60, MinimumLength = 3), Required]
        public string ConductingLeader { get; set;}

        [Display(Name = "Open Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string OpenHymn { get; set; }

        [Display(Name = "Invocation")]
        [StringLength(60, MinimumLength = 3), Required]
        public string OpenPrayer { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string SacramentHymn { get; set;}

        [Display(Name = "Speaker")]
        [StringLength(60, MinimumLength = 3), Required]
        public string SpeakerSacrament { get; set; }

        [Display(Name = "Closing Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string ClosingHymn { get; set;}

        [Display(Name = "Benediction")]
        [StringLength(60, MinimumLength = 3), Required]
        public string ClosingPrayer { get; set;}


    }
}
