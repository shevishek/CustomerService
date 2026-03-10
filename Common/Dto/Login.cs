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
        [Required(ErrorMessage = "סיסמא הינה שדה חובה")]
        public string PasswordHash { get; set; }

        [EmailAddress(ErrorMessage = "כתובת האימייל אינה תקינה")]
        public string Email { get; set; } // הוספתי אימייל כדוגמה לוולידציה חשובה
    }
}
