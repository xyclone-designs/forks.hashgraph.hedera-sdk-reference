using Hiero.Reference.Core;

namespace Hiero.Reference.Transaction
{
    public interface ITransactionRecord { }
    public interface ITransactionRecord<TSelf> : ITransaction where TSelf : ITransactionRecord<TSelf> { }
}
