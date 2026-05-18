using Hiero.Reference.Core;

namespace Hiero.Reference.Transaction
{
    public interface ITransactionFeeSchedule { }
    public interface ITransactionFeeSchedule<TSelf> : ITransaction where TSelf : ITransactionFeeSchedule<TSelf> { }
}
