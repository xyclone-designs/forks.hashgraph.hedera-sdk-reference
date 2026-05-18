using Hiero.Reference.Core;

namespace Hiero.Reference.Consensus
{
    public interface ITopicDeleteTransaction : ITransaction
    {
        /// <summary>
        /// The `topicId` which should be deleted
        /// </summary>
        ITopicId TopicId { get; }
    }
}
