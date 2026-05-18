using System.Collections.Generic;

namespace Hiero.Reference.Hook
{
    public interface IEvmHookMappingEntries : IEvmHookStorageUpdate
    {
        byte[] MappingSlot { get; }
        IList<IEvmHookMappingEntry> Entries { get; }
    }
    public interface IEvmHookMappingEntries<TSelf> : IEvmHookMappingEntries, IEvmHookStorageUpdate<TSelf> where TSelf : IEvmHookStorageUpdate<TSelf>
    {
        abstract static TSelf CTOR(byte[] mappingSlot, IEnumerable<IEvmHookMappingEntry> entries);
    }
}
