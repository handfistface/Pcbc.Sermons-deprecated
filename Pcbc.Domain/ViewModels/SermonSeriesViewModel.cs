namespace Pcbc.Domain.ViewModels
{
    /// <summary>
    ///     Represents a sermon series which is a collection of sermons
    /// </summary>
    public class SermonSeriesViewModel
    {
        /// <summary>
        ///     The sermon files that can be played
        /// </summary>
        public List<AudioFileViewModel> SermonAudioFiles { get; set; }

        /// <summary>
        ///     name of the sermon series
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Path to the banner image for the series
        /// </summary>
        public string BannerNetworkPath { get; set; }
    }
}
