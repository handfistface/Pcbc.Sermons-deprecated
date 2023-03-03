using Pcbc.Domain.Factories;
using Pcbc.Domain.ViewModels;

namespace Pcbc.Domain.Builders
{
    /// <summary>
    ///     Builds the AudioFileViewModel objects.
    /// </summary>
    public class AudioFileViewModelBuilder 
        : IAudioFileViewModelBuilder
    {
        private FileInfo AudioFile { get; set; } = null;

        public AudioFileViewModel Build()
        {
            if (AudioFile == null)
                throw new NullReferenceException(nameof(AudioFile));

            //populate the sermon audio file
            var vm = new AudioFileViewModel()
            {
                FileName = AudioFile.Name.Replace(AudioFile.Extension, ""),
                FullFileName = AudioFile.FullName,
                FileExtension = AudioFile.Extension,
                NetworkPath = $"/Sermons/{AudioFile.Directory.Name}/{AudioFile.Name}"
            };
            return vm;
        }

        public IAudioFileViewModelBuilder WithAudioFile(FileInfo audioFile)
        {
            AudioFile = audioFile;
            return this;
        }
    }
}
