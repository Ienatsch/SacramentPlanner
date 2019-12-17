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

        [StringLength(60, MinimumLength = 3)]
        public string WardBranch { get; set; }
        
        [Display(Name= "Sabbath Day"), DataType(DataType.Date)]
        public DateTime SabbathDay { get; set;}

        [Display(Name = "Conducting")]
        [StringLength(60, MinimumLength = 3)]
        public string ConductingLeader { get; set;}

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string OpenHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string OpenPrayer { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string SacramentHymn { get; set;}

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string ClosingHymn { get; set;}

        [StringLength(60, MinimumLength = 3)]
        public string ClosingPrayer { get; set;}


        public List<Speaker> Speakers { get; set; }

    }
}
