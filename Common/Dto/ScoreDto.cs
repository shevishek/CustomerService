using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class ScoreDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "חובה להזין ציון")]
        [Range(0, 100, ErrorMessage = "הציון חייב להיות בין 0 ל-100")]
        public int Value { get; set; }

        [StringLength(500, ErrorMessage = "הערה לא יכולה לעלות על 500 תווים")]
        public string Note { get; set; }

        public int CallId { get; set; }
    }
}
