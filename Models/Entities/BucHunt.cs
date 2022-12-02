using System.ComponentModel.DataAnnotations;

namespace Team2BucHunt.Models.Entities
{
    public class BucHunt
    {
        [StringLength(256)]
        public string? Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        public ICollection<Person> People { get; set; } = new List<Person>();
    }
}
