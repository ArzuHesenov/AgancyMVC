namespace AgencyDB.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string PhotoUrl { get; set; }
        public List<TeamNetwork> TeamNetworks { get; set; }
    }
}
