using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Repository.Entities
{
    public class Call
    {
        [Key]
        public int CallId { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public DateTime CallDate { get; set; }

        public TimeSpan? Duration { get; set; }

        public string? Notes { get; set; }

        // קשרי גומלין
        [ForeignKey("OfficeId")]
        public virtual Company Company { get; set; }

        public virtual ICollection<CallParticipantAnalysis> CallParticipants { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
