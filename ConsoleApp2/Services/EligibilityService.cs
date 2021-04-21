using RewardsService.Exceptions;

namespace RewardsService.Services
{
    public abstract class EligibilityService : IEligibilityService
    {
        public string CheckEligibilityService(string accountNumber)
        {
            var eligibility = "CUSTOMER_INELIGIBLE";

            switch (accountNumber)
            {
                case "1111":
                    eligibility = "CUSTOMER_ELIGIBLE";
                    break;
                case "2222":
                    eligibility = "CUSTOMER_INELIGIBLE";
                    break;
                case "3333":
                    throw new InvalidAccountNumberException("The Supplied Account Number is Invalid");
                case "4444":
                    throw new TechnicalFailureException("Service Technical Failure");
            }

            return eligibility;
        }
    }
}