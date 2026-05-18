using Hiero.Reference.Core;

namespace Hiero.Reference.File
{
    /// <summary>
    /// Query a file's current state.
    /// </summary>
    public interface IFileInfoQuery : IQuery<IFileInfo>
    {
        /// <summary>
        /// This is the file ID for which info will be queried for.
        /// </summary>
        IFileId IFileId { get; }
    }
}
