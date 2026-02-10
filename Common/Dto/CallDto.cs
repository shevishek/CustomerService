using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class CallDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "חובה להזין תאריך שיחה")]
        public DateTime CallDate { get; set; }

        [Range(0, 1000, ErrorMessage = "משך שיחה חייב להיות מספר חיובי (בדקות)")]
        public double Duration { get; set; }

        [Required]
        public int OperatorId { get; set; }

        // ניתן להוסיף שדות עזר לתצוגה בלבד
        public string OperatorName { get; set; }
    }
}
