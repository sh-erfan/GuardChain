using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Models;

namespace GuardChain.Utils
{
    public static class Chain
    {
        public static IChainableGuardClause<TInput> Next<TInput>(IGuardClause<TInput> previousGuard)
        {
            return new ChainableGuardClause<TInput>(previousGuard);
        }

    }
}
