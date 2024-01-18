using System;
using System.Collections.Generic;
using System.Text;

namespace GuardChain.Contracts
{
    public interface IGuardClause<out TInput>
    {
        /// <summary>
        /// Value that is passed into Protect() method or the latest And() method.
        /// </summary>
        TInput Input { get; }
        string InputParameterName { get; }

    }
}
