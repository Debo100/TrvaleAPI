using Microsoft.Extensions.Configuration;
using TravelApi.Model.Request;
using TravelAPI.Data.Interfaces;

namespace TravelAPI.Data.Implementations
{
    public class TravelellerRepository : BaseRepository, ITravelellerRepository
    {
        public readonly IConfiguration _configuration;

        public TravelellerRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        
        public Task<bool> SaveUserPostDetails(UserPostDetails userPostDetails)
        {
            throw new NotImplementedException();
        }
    }
}
