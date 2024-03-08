using Sports_API.Models;

namespace Sports_API.Interfaces
{
    public interface ISportsDataLayer
    {
        Task<bool> PlaySportsGame();
    }
}
