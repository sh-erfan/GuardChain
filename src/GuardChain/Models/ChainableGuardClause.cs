using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Contracts;
using GuardChain.Utils;

namespace GuardChain.Models
{
    public sealed class ChainableGuardClause<TInput> : GuardClause<TInput>, IChainableGuardClause<TInput>
    {
        public IInitialGuardClause<TNewInput> Protect<TNewInput>(TNewInput input)
        {
            return Guard.Protect(input);
        }

        public IInitialGuardClause<TNewInput> Protect<TNewInput>(TNewInput input, string inputParameterName)
        {
            return Guard.Protect(input, inputParameterName);
        }

        internal ChainableGuardClause(TInput input) : base(input) { }
        internal ChainableGuardClause(TInput input, string inputParameterName) : base(input, inputParameterName) { }
        internal ChainableGuardClause(IGuardClause<TInput> guard) : base(guard) { }
    }
}
