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
    public class CallParticipantAnalysis
    {
        [Key]
        public int ParticipantId { get; set; }

        [Required]
        public int CallId { get; set; }

        public int? OperatorId { get; set; } // יכול להיות NULL עבור לקוח

        [Required]
        [MaxLength(50)]
        public string ParticipantType { get; set; } // 'Operator' או 'Customer'

        public double? AvgVolume { get; set; }
        public double? PeakVolume { get; set; }
        public TimeSpan? Duration { get; set; }
        public double? WordsPerSecond { get; set; }
        public string? Transcript { get; set; }
        public double? Score { get; set; }
        public string? ImprovementNotes { get; set; }

        // קשרי גומלין
        [ForeignKey("CallId")]
        public virtual Call Call { get; set; }

        [ForeignKey("OperatorId")]
        public virtual Operator? Operator { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
