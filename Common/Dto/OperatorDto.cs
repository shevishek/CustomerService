using Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class OperatorDto
    {
        public int OperatorId { get; set; }

        [Required(ErrorMessage = "שם פרטי הוא שדה חובה")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "שם משפחה הוא שדה חובה")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "כתובת האימייל אינה תקינה")]
        public string Mail { get; set; } // הוספתי אימייל כדוגמה לוולידציה חשובה

        [Required(ErrorMessage = "מזהה חברה הינו שדה חובה")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "תאריך הינו שדה חובה")]
        public DateTime HireDate { get; set; }=DateTime.Now;

        [Phone(ErrorMessage = "מספר טלפון הינו שדה חובה")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "סיסמא הינה שדה חובה")]
        public string PasswordHash { get; set; }

        public UserRole Role { get; set; } = UserRole.Operator;

    }
}
