using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Operator
    {
        [Key]
        public int OperatorId { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime? HireDate { get; set; }

        public string? Mail { get; set; }

        public string? Phone { get; set; }

        public double? MonthlyScore { get; set; }

        public double? DailyScore { get; set; }

        // קשרי גומלין
        [ForeignKey("OfficeId")]
        public virtual Company Company { get; set; }

        public virtual ICollection<CallParticipantAnalysis> ParticipantAnalyses { get; set; }
    }
}
