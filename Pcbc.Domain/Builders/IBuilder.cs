namespace Pcbc.Domain.Factories
{
    /// <summary>
    ///     Interface for all builders
    /// </summary>
    /// <typeparam name="ToBuild">The type that gets built</typeparam>
    public interface IBuilder<ToBuild>
    {
        /// <summary>
        ///     Creates an instance of the given type.
        /// </summary>
        ToBuild Build();
    }
}
