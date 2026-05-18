using Hiero.Reference.Core;

namespace Hiero.Reference.Transaction
{
    public interface ITransactionReceipt { }
    public interface ITransactionReceipt<TSelf> : ITransaction where TSelf : ITransactionReceipt<TSelf> { }
}
