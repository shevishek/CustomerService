using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class CallParticipantAnalysisDto
    {
        public int Id { get; set; }

        [Required]
        public int CallId { get; set; }

        [Required(ErrorMessage = "חובה לציין את תפקיד המשתתף")]
        public string ParticipantRole { get; set; } // למשל: "לקוח" או "נציג"

        [Range(-1, 1, ErrorMessage = "מדד הסנטימנט חייב להיות בין 1- ל-1")]
        public double SentimentScore { get; set; } // דוגמה לניתוח רגש

        [Required(ErrorMessage = "חובה להזין את תמלול השיחה או חלק ממנו")]
        public string TranscriptSnippet { get; set; }
    }
}
