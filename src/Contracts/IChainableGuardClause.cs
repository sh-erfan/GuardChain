
namespace GuardChain.Contracts
{
    public interface IChainableGuardClause<out TInput> : IGuardClause<TInput>
    {
        IInitialGuardClause<TNewInput> Protect<TNewInput>(TNewInput input);

    }
}
