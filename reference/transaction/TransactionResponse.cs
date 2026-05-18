using Hiero.Reference.Core;

namespace Hiero.Reference.Transaction
{
    public interface ITransactionResponse { }
    public interface ITransactionResponse<TSelf> : ITransaction where TSelf : ITransactionResponse<TSelf> { }
}
