using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace GuardChain.Contracts
{
    public interface IChainableGuardClause<out TInput> : IGuardClause<TInput>
    {
        IInitialGuardClause<TNewInput> Protect<TNewInput>(TNewInput input);

    }
}
