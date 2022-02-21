using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface IStandingOrders
    {
        /// <summary>
        /// Retrieve the standing orders for an account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Standing Orders Response</returns>
        [Get("/accounts/{accountId}/standing-orders")]
        [Headers()] 
        Task<StandingOrdersGetAllResponse> StandingOrdersGetAllAsync([AliasAs("accountId")] System.Guid accountId, [Header("Authorization")] string bearerToken);

    }
}