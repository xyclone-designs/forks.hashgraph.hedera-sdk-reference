
namespace Hiero.Reference.Hook
{
    public interface IHookEntityId { }
    public interface IHookEntityId<TSelf> : IHookEntityId where TSelf : IHookEntityId<TSelf> { }
}
