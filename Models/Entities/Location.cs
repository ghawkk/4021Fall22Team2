namespace Team2BucHunt.Models.Entities
{
    /// <summary>
    /// Models a scavenger hunt location.
    /// </summary>
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        // Because a location can have multiple tasks associated with it, a collection of HuntTasks can be
        // read in along with a given Location instance.
        public ICollection<HuntTask> HuntTasks { get; set; } = new List<HuntTask>();
    }
}
