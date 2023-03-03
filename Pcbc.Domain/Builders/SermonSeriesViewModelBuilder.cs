using Pcbc.Domain.ViewModels;

namespace Pcbc.Domain.Builders
{
    /// <summary>
    ///     Builds SermonSeriesViewModels
    /// </summary>
    public class SermonSeriesViewModelBuilder 
        : ISermonSeriesViewModelBuilder
    {
        /// <summary>
        ///     Directory which the sermon series is stored
        /// </summary>
        private DirectoryInfo SermonDirectory { get; set; } = null;

        private readonly IAudioFileViewModelBuilder AudioFileViewModelBuilder;

        public SermonSeriesViewModelBuilder(
            IAudioFileViewModelBuilder audioFileViewModelBuilder
            )
        {
            AudioFileViewModelBuilder = audioFileViewModelBuilder;
        }

        public SermonSeriesViewModel Build()
        {
            var vm = new SermonSeriesViewModel();

            vm.Name = SermonDirectory.Name;

            //populate the thumbnail image
            vm.BannerNetworkPath = SermonDirectory
                .GetFiles("*.jpg")
                .Select(f => $"/Sermons/{vm.Name}/{f.Name}")
                .First();

            //populate the collection of audio files
            var audioFiles = SermonDirectory
                .GetFiles("*.m4a")
                .ToList();
            vm.SermonAudioFiles = new List<AudioFileViewModel>();
            foreach ( var audioFile in audioFiles )
            {
                vm.SermonAudioFiles.Add(
                    AudioFileViewModelBuilder.WithAudioFile(audioFile).Build()
                );
            }


            return vm;
        }

        public ISermonSeriesViewModelBuilder WithDirectoryName(DirectoryInfo directoryName)
        {
            SermonDirectory = directoryName;
            return this;
        }
    }
}
