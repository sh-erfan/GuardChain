using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Contracts;
using GuardChain.Utils;

namespace GuardChain.Models
{
    public class GuardClause<TInput> : IGuardClause<TInput>
    {

        public TInput Input { get; }
        public string InputParameterName { get; }

        internal GuardClause(TInput input)
        {
            Input = input;
            InputParameterName = "GuardInput";
        }

        internal GuardClause(TInput input, string inputParameterName)
        {
            Input = input;
            InputParameterName = inputParameterName;
        }

        internal GuardClause(IGuardClause<TInput> guard)
        {
            Input = guard.Input;
            InputParameterName = guard.InputParameterName;
        }


    }
}
