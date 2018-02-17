﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerLibrary
{
    [Table("Skill")]
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string SkillName { get; set; }
    }
}
