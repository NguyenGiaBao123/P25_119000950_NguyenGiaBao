using System.ComponentModel.DataAnnotations;
namespace P25_119000950_NguyenGiaBao.Models
{
    public class category
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required]
        public string Name { get; set; }=string.Empty;
    }
}