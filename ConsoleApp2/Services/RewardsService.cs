using System;
using System.Collections.Generic;
using System.Linq;

namespace RewardsService.Services
{
    public class RewardsService : IRewardsService
    {

        public List<string> FetchRewards(string accountNumber, List<string> subscriptions)
        {
            throw new NotImplementedException();
        }
       
            Dictionary<string, string> rewardsMap = new Dictionary<string, string>
            {
                { "SPORTS", "CHAMPIONS_LEAGUE_FINAL_TICKET" },
                { "MUSIC", "KARAOKE_PRO_MICROPHONE" },
                { "MOVIES", "PIRATES_OF_THE_CARIBBEAN_COLLECTION" }
            };

        private EligibilityService eligibilityService;

        public List<string> fetchRewards(string accountNumber, IEnumerable<string> subscriptions)
        {
            var eligibility = eligibilityService.CheckEligibilityService(accountNumber);
            var rewards = new List<string>();

            if (eligibility.Equals("CUSTOMER_ELIGIBLE"))
            {
                rewards = GetRewards(subscriptions);
            }

            return rewards;
        }

        private List<string> GetRewards(IEnumerable<string> subscriptions)
        {
            return (from subscription in subscriptions where rewardsMap.ContainsKey(subscription)
                    select rewardsMap.GetValueOrDefault(subscription)).ToList();
        }
    }
}