using Pcbc.Domain.Factories;
using Pcbc.Domain.ViewModels;

namespace Pcbc.Domain.Builders
{
    /// <summary>
    ///     Interface for building sermon series view models.
    /// </summary>
    public interface ISermonSeriesViewModelBuilder : IBuilder<SermonSeriesViewModel>
    {
        public ISermonSeriesViewModelBuilder WithDirectoryName(DirectoryInfo directory);
    }
}
