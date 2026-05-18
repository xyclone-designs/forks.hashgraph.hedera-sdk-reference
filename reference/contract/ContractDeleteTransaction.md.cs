using Hiero.Reference.Core;
using Hiero.Reference.Cryptocurrency;

namespace Hiero.Reference.Contract
{
    public interface IContractDeleteTransaction : ITransaction
    {
        /// <summary>
        /// The ID of the contract to be deleted.
        /// </summary>
        IContractId ContractId { get; }

        /// <summary>
        /// The ID of an account that will receive any remaining `Hbar` from the deleted contract.
        /// </summary>
        IAccountId TransferAccountId { get; }

        /// <summary>
        /// The ID of a contract that will receive any remaining `Hbar` from the deleted contract
        /// </summary>
        IContractId TransferContractId { get; }
    }
}
