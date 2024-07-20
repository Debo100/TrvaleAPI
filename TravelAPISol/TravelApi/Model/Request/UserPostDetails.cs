using System.Text;

namespace TravelApi.Model.Request
{
    public class UserPostDetails
    {
        public string UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public List<string>? Destinations { get; set; }
        public double Budget { get; set; }
        public DateTime EstimatedDateStart {  get; set; }
        public DateTime EstimatedDateEnd { get; set; }
        public string Address { get; set; } = string.Empty;
        

    }
}
