using System;

namespace RewardsService.Exceptions
{
    public class TechnicalFailureException: Exception
    {
        private const long serialVersionUID = 1;
        private string _errorMessage;

        public TechnicalFailureException(string message) : base(message) { }

        private string TechnicalFailureErrorMessage(string errorMessage)
        {
            this._errorMessage = errorMessage;
            return errorMessage;
        }
    }
}