using System;

namespace ExercicioFExcecoes.Entities.Exceptions
{
    class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message)
        {
        }
    }
}
