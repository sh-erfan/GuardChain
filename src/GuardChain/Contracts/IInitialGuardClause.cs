using System;
using System.Collections.Generic;
using System.Text;

namespace GuardChain.Contracts
{
    public interface IInitialGuardClause<out TInput>
    {
        IGuardClause<TInput> Against { get; }
    }
}
