using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface IBeneficiaries
    {
        /// <summary>
        /// Retrieve all beneficiaries for a user
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <param name="isUnique">Whether the beneficiaries returned include duplicates with differing references</param>
        /// <returns>Successful Beneficiaries Response</returns>
        [Get("/beneficiaries")]
        [Headers()] 
        Task<BeneficiariesGetAllResponse> BeneficiariesGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset,[Query][AliasAs("isUnique")] bool? isUnique, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a single beneficiary
        /// </summary>
        /// <param name="beneficiaryId">The Beneficiary Id</param>
        /// <returns>Successful Beneficiary Response</returns>
        [Get("/beneficiaries/{beneficiaryId}")]
        [Headers()] 
        Task<BeneficiariesGetResponse> BeneficiariesGetAsync([AliasAs("beneficiaryId")] System.Guid beneficiaryId, [Header("Authorization")] string bearerToken);

    }
}