using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace GuardChain.Models
{
    public interface IChainableGuardClause<out TInput> : IGuardClause<TInput>
    {
        IInitialGuardClause<TNewInput> Protect<TNewInput>(TNewInput input);

    }
}
