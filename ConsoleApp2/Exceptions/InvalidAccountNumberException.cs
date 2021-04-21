using System;

namespace RewardsService.Exceptions
{
    public class InvalidAccountNumberException: Exception
    {
        private static readonly long serialVersionUID = 1;
        private string _errorMessage;

        public InvalidAccountNumberException(string message) : base(message) {}

        private string InvalidAccountNumberErrorMessage(string errorMessage)
        {
            this._errorMessage = errorMessage;
            return errorMessage;
        }
    }
}