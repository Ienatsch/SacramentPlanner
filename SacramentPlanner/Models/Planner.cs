using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MeetingPlanner.Models
{
    public class Planner
    {
        public int SacaramentID { get; set; }
        public string WardBranch { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime SabbathDay { get; set;}
        public string ConductingLeader { get; set;}
        public string OpenHymn { get; set; }
        public string OpenPrayer { get; set; }
        public string SacramentHymn { get; set;}
        public string ClosingHymn { get; set;}
        public string ClosingPrayer { get; set;}




    }
}
