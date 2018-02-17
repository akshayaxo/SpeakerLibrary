using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerLibrary
{
    [Table("Prerequite")]
    public class Prerequisite
    {
        [Key]
        public int ID { get; set; }

        //[ForeignKey("NavEvent")]
        public int EventID { get; set; }
        // public Event  NavEvent{ get; set; }
        public int SpeakerProfileID { get; set; }

        public int TopicID { get; set; }
        public string File { get; set; }
    }
}
