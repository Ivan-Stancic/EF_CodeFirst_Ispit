using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models.Dbo
{
    public class Grade :TableCommon
    {
        public string Title { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        public int StudentId { get; set; }

        public string GradeName { get; set; }
        public string Section { get; set; }

    }
}
