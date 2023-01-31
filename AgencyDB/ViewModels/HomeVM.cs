using AgencyDB.Models;

namespace AgencyDB.ViewModels
{
    public class HomeVM
    {
        public Banner Banner { get; set; }
        public List<About> Abouts { get; set; }
        public List<Service> Services { get; set; }
        public Contact Contact { get; set; } 
        public List<Partner> Partners { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Team> Teams { get; set; }
    }
}
