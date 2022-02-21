using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface ITax
    {
        /// <summary>
        /// Retrieve transactions to help answer SA105 - the Self Assessment questions for properties for HMRC
        /// </summary>
        /// <param name="startDate">The date to get transactions from</param>
        /// <param name="endDate">The date to get transactions to</param>
        /// <param name="projectId">The project ID the transactions belong to</param>
        /// <param name="accountId">The account ID the transactions belong to</param>
        /// <returns>Successful Tax Response</returns>
        [Get("/tax")]
        [Headers()] 
        Task<TaxGetResponse> TaxGetAsync([Query][AliasAs("startDate")] System.DateTimeOffset startDate,[Query][AliasAs("endDate")] System.DateTimeOffset endDate,[Query][AliasAs("projectId")] string projectId,[Query][AliasAs("accountId")] string accountId, [Header("Authorization")] string bearerToken);

    }
}