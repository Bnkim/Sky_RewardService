using System.Collections.Generic;

namespace RewardsService
{
    public interface IRewardsService
    {
        List<string> FetchRewards(string accountNumber, List<string> subscriptions);
    }
}