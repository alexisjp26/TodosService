using System.ComponentModel.DataAnnotations;

namespace TodosService.Dtos
{
    public record TaskReadDto
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool Completed { get; set; }
    }
}