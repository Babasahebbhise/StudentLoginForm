using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KiranAssesment.Models
{
    public class Student
    {
        [Column("StudentName", TypeName = "varchar(300)")]
        public string StudentName { get; set; }
        [Column("DateOfBirth", TypeName = "date")]
        public DateOnly DateOfBirth { get; set; }

        [Key]
        [Column("Email", TypeName = "varchar(300)")]
        public string Email { get; set; }

        [Column("Gender", TypeName = "varchar(300)")]
        public string Gender { get; set; }

        [Column("Language", TypeName = "varchar(300)")]
        public string Language { get; set; }

        public override string ToString()
        {
            return ("Name" + StudentName + " " + "DOB" + DateOfBirth + " " + "Email" + Email + " " + "Gender" + Gender + " " + "Language" + Language);
        }
    }
}
