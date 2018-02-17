using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerLibrary
{
    [Table("SpeakerSkillMap")]
   public class SpeakerSkillMap
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("NavSkill")]
        public int SkillID { get; set; }

        [ForeignKey("NavProfile")]
        public int SpeakerProfileID { get; set; }
        public int Rating { get; set; }
        public Skill NavSkill { get; set; }
        public SpeakerProfile NavProfile{ get; set; }

    }
}
