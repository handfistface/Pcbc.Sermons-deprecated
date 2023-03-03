using Pcbc.Domain.Factories;
using Pcbc.Domain.ViewModels;

namespace Pcbc.Domain.Builders
{
    /// <summary>
    ///     Interface for building audio file view model objects.
    /// </summary>
    public interface IAudioFileViewModelBuilder : IBuilder<AudioFileViewModel>
    {
        IAudioFileViewModelBuilder WithAudioFile(FileInfo audioFile);
    }
}
