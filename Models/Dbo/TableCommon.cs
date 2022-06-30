using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models.Dbo
{
    public class TableCommon
    {
        [Key]
        public int Id { get; set; }
    }
}
