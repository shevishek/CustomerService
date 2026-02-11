using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class Login
    {
        [Required(ErrorMessage = "שם פרטי הוא שדה חובה")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "שם משפחה הוא שדה חובה")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "כתובת האימייל אינה תקינה")]
        public string Email { get; set; } // הוספתי אימייל כדוגמה לוולידציה חשובה
    }
}
