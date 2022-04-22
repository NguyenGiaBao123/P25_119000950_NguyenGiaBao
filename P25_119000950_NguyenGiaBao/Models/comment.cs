using System.ComponentModel.DataAnnotations;
namespace P25_119000950_NguyenGiaBao.Models
{
    public class comment
    {
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }=string.Empty;
        [Required]
        public string Content { get; set; }=string.Empty;
        public string CreateAt { get; set; }=string.Empty;
    }
}