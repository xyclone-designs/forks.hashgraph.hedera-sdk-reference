using Hiero.Reference.Core;

namespace Hiero.Reference.File
{
    /// <summary>
    /// Delete a file that exists on the Hedera Hashgraph network.
    /// </summary>
    public interface IFileDeleteTransaction : ITransaction
    {
        /// <summary>
        /// This is the ID of the file to delete.
        /// </summary>
        IFileId IFileId { get; }
    }
}
