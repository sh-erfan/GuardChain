using System;
using System.Collections.Generic;
using System.Text;
using GuardChain.Contracts;

namespace GuardChain.Models
{
    internal sealed class InitialGuardClause<TInput> : IInitialGuardClause<TInput>
    {
        private readonly TInput _input;
        private readonly string _inputParameterName;
       
        internal InitialGuardClause(TInput input)
        {
            _input = input;
            _inputParameterName = "GuardInput";
        }

        internal InitialGuardClause(TInput input, string inputParameterName)
        {
            _input = input;
            _inputParameterName = inputParameterName;
        }

        public IGuardClause<TInput> Against => new GuardClause<TInput>(_input, _inputParameterName);
    }
}
