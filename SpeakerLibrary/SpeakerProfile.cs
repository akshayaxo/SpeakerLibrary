using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerLibrary
{
    [Table("SpeakerProfile")]
    public class SpeakerProfile
    {
        [Key]
        public int SpeakerProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Qualification { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string SelfDescriotion { get; set; }
        public byte[] ProfilePhoto { get; set; }



    }
}
