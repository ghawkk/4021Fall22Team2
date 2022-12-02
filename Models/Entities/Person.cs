using System.ComponentModel.DataAnnotations;

namespace Team2BucHunt.Models.Entities
{
    public class Person
    {
        [StringLength(30)]
        public string? FirstName { get; set; }
        [StringLength(30)]
        public string? LastName { get; set; }
        [StringLength (256)]
        public string BucHuntID { get; set; } = string.Empty;
        public BucHunt? BucHunt { get; set; }
    }
}
