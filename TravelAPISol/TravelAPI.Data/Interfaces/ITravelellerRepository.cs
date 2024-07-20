using TravelApi.Model.Request;

namespace TravelAPI.Data.Interfaces
{
    public interface ITravelellerRepository
    {
        Task<bool> SaveUserPostDetails(UserPostDetails userPostDetails);
    }
}
