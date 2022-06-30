namespace EF_CodeFirst.Models.Dbo
{
    public class Student : TableCommon
    {
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
    }
}
