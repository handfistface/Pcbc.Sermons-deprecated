namespace Pcbc.Domain.ViewModels
{
    /// <summary>
    ///     Represents an audio file
    /// </summary>
    public class AudioFileViewModel
    {
        public string FileName { get; set; }
        public string FullFileName { get; set; }
        public string FileExtension { get; set; }
        public string NetworkPath { get; set; }
    }
}
