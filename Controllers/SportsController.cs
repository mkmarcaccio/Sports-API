using Microsoft.AspNetCore.Mvc;
using Sports_API.Interfaces;
using Sports_API.Models;
using System.Threading;

namespace Sports_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SportsController : ControllerBase
    {
        private readonly ISportsDataLayer _sportsDataLayer;

        public SportsController(ISportsDataLayer sportsDataLayer)
        {
            _sportsDataLayer = sportsDataLayer;
        }

        [HttpGet]
        [Route("/api/playSportsGame")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<string> PlaySportsStandardAwait()
        {
            await _sportsDataLayer.PlaySportsGame();

            return "We won the Game!";
        }

        [HttpGet]
        [Route("/api/playSportsGameInBackground")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string PlaySportsInBackground()
        {
            new Thread(() =>
            { 
                Thread.CurrentThread.IsBackground = true;

                _sportsDataLayer.PlaySportsGame();
            }).Start();
            
            return "The Hockey Game is starting.";
        }
    }
}
