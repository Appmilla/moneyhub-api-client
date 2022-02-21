using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface IHoldings
    {
        /// <summary>
        /// Retrieve the holdings for an account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Holdings Response</returns>
        [Get("/accounts/{accountId}/holdings")]
        [Headers()] 
        Task<HoldingsAccountIdResponse> HoldingsAccountIdGetAllAsync([AliasAs("accountId")] System.Guid accountId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve the holding for an account with matched ISIN codes
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <param name="holdingId">The Holding Id</param>
        /// <returns>Successful Holding Response</returns>
        [Get("/accounts/{accountId}/holdings/{holdingId}")]
        [Headers()] 
        Task<HoldingsWithIsinGetResponse> HoldingsWithIsinGetAsync([AliasAs("accountId")] System.Guid accountId,[AliasAs("holdingId")] string holdingId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve the holdings for an account with matched ISIN codes
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Holdings Response</returns>
        [Get("/accounts/{accountId}/holdings-with-matches")]
        [Headers()] 
        Task<HoldingsWithIsinGetAllResponse> HoldingsWithIsinGetAllAsync([AliasAs("accountId")] System.Guid accountId, [Header("Authorization")] string bearerToken);

    }
}