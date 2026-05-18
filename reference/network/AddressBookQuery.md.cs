using Hiero.Reference.Core;
using Hiero.Reference.File;

namespace Hiero.Reference.Network
{
    public interface IAddressBookQuery
    {
        /// <summary>
        /// Execute this query against a mirror node to get the address book.
        /// </summary>
        IAddressBook Execute(IClient client);

        /// <summary>
        /// The file ID of the address book to query
        ///
        /// **NOTE**: You can use `FileId.ADDRESS_BOOK`
        /// </summary>
        IFileId IFileId { get; }

        /// <summary>
        /// Limit the amount of nodes to return. If unset will return entire address book.
        /// </summary>
        uint? Limit { get; }
    }
}
