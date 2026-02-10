using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Score
    {
        [Key]
        public int ScoreId { get; set; }

        [Required]
        public int ParticipantId { get; set; }

        [Required]
        public int CallId { get; set; }

        public double? AvgVolumeScore { get; set; }
        public double? PeakVolumeScore { get; set; }
        public double? WordsPerSecondScore { get; set; }
        public double? OverallScore { get; set; }
        public string? Notes { get; set; }

        // קשרי גומלין
        [ForeignKey("ParticipantId")]
        public virtual CallParticipantAnalysis Participant { get; set; }

        [ForeignKey("CallId")]
        public virtual Call Call { get; set; }
    }
}
