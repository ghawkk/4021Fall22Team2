namespace Team2BucHunt.Models.Entities
{
    /// <summary>
    /// Models a scavenger hunt task.
    /// </summary>
    public class HuntTask
    {
        public int Id { get; set; }
        public string Question { get; set; } = String.Empty;
        public string Answer { get; set; } = String.Empty;

        // The following properties set up the one-to-many foreign key relationship between Locations and HuntTasks
        public int LocationId { get; set; }
        public Location? Location { get; set; }
    }
}
