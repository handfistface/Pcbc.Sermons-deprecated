using Microsoft.AspNetCore.Mvc;
using Pcbc.Domain.Configuration;
using Pcbc.Domain.Factories;
using Pcbc.Domain.ViewModels;

namespace Pcbc.Sermons.Controllers
{
    [ApiController]
    public class LectureController : ControllerBase
    {
        private readonly IBuilder<SermonsViewModel> _sermonBuilder;

        public LectureController(
            IBuilder<SermonsViewModel> sermonBuilder
            )
        {
            _sermonBuilder = sermonBuilder;
        }

        [HttpGet]
        [Route("[controller]/[action]")]
        public SermonsViewModel GetAllSermons()
        {
            var vm = _sermonBuilder.Build();

            return vm;
        }

        [HttpGet]
        [Route("[controller]/[action]/{seriesName}")]
        public SermonSeriesViewModel GetSeries(string seriesName)
        {
            return null;
        }
    }
}
