using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface ISpendingAnalysis
    {
        /// <summary>
        /// Retrieve spending analysis by categories, projects and accounts
        /// </summary>
        /// <returns>Successful Spending Analysis Response</returns>
        [Post("/spending-analysis")]
        [Headers()] 
        Task<SpendingAnalysisGetResponse> SpendingAnalysisGetAsync([Body][AliasAs("body")] SpendingAnalysisRequest spendingAnalysisRequest, [Header("Authorization")] string bearerToken);

    }
}