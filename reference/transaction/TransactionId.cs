using Hiero.Reference.Core;

namespace Hiero.Reference.Transaction
{
    public interface ITransactionId { }
    public interface ITransactionId<TSelf> : ITransaction where TSelf : ITransactionId<TSelf> { }
}
