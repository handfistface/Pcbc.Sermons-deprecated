using Pcbc.Domain.Builders;
using Pcbc.Domain.Configuration;
using Pcbc.Domain.ViewModels;

namespace Pcbc.Domain.Factories
{
    /// <summary>
    ///     Builds SermonViewModels.
    /// </summary>
    public class SermonsViewModelBuilder : IBuilder<SermonsViewModel>
    {
        private readonly ISermonSeriesViewModelBuilder sermonSeriesBuilder;

        public SermonsViewModelBuilder(
            ISermonSeriesViewModelBuilder sermonSeriesBuilder
            )
        {
            this.sermonSeriesBuilder = sermonSeriesBuilder;
        }

        /// <inheritdoc/>
        public SermonsViewModel Build()
        {
            var vm = new SermonsViewModel();

            //build the sermon series properties
            vm.SermonSeries = new List<SermonSeriesViewModel>();
            foreach (var directory in DomainConfiguration.SermonsDirectory.GetDirectories())
            {
                vm.SermonSeries.Add(
                    sermonSeriesBuilder
                    .WithDirectoryName(directory)
                    .Build()
                    );
            }

            return vm;
        }
    }
}
