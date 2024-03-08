using RockLib.Logging;
using Sports_API.Interfaces;
using Sports_API.Models;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Sports_API.DataLayer
{
    public class SportsDataLayer : ISportsDataLayer
    {
        private readonly ILogger _logger;
        
        public SportsDataLayer(ILogger<SportsDataLayer> logger)
        {
            _logger = logger;
        }
        public async Task<bool> PlaySportsGame()
        {
            _logger.LogInformation("Mike shoots the puck.");
            await Task.Delay(10*1000);
            _logger.LogInformation("Mike Scores!!!");
            return true;
        }
    }
}
