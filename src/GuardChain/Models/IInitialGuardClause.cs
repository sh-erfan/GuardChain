using System;
using System.Collections.Generic;
using System.Text;

namespace GuardChain.Models
{
   public interface IInitialGuardClause<out TInput>
    {
        IGuardClause<TInput> Against { get; }
    }
}
