using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }
        public int SacramentID { get; set; }

        public string NameSpeaker { get; set; }
        public string SpeakerSubject { get; set; }
    } 
}
