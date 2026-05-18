using Hiero.Reference.Core;

namespace Hiero.Reference.File
{
    public interface IFileContentsQuery : IQuery<byte[]>
    {
        /// <summary>
        /// This is the fileID which contents queried for.
        /// </summary>
        IFileId FileId { get; }
    }
}
