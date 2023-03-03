namespace Pcbc.Domain.Configuration
{
    /// <summary>
    ///     Contains some configuration settings that will be used throughout the program
    /// </summary>
    public static class DomainConfiguration
    {
        /// <summary>
        ///     This is where all of the sermons are stored.
        /// </summary>
        public static DirectoryInfo SermonsDirectory =
            new DirectoryInfo(@".\ClientApp\src\Sermons");
    }
}
