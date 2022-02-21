using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    public interface IPayments
    {
        /// <summary>
        /// Retrieve all payments created by an API client
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <param name="userId">The ID of the user to filter transactions on</param>
        /// <param name="payeeId">The ID of the payee to filter transactions on</param>
        /// <param name="startDate">The date to start filtering transactions on</param>
        /// <param name="endDate">The date to end filtering transactions on</param>
        /// <returns>Succesful Payment Response</returns>
        [Get("/payments")]
        [Headers()] 
        Task<PaymentsGetAllResponse> PaymentsGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset,[Query][AliasAs("userId")] string userId,[Query][AliasAs("payeeId")] string payeeId,[Query][AliasAs("startDate")] System.DateTimeOffset? startDate,[Query][AliasAs("endDate")] System.DateTimeOffset? endDate);

        /// <summary>
        /// Retrieve a single payment
        /// </summary>
        /// <param name="paymentId">The payment Id</param>
        /// <returns>Successful Payment Response</returns>
        [Get("/payments/{paymentId}")]
        [Headers()] 
        Task<PaymentsGetResponse> PaymentsGetAsync([AliasAs("paymentId")] System.Guid paymentId);

        /// <summary>
        /// Retrieve all standing orders created by an API client
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <param name="userId">The ID of the user to filter transactions on</param>
        /// <returns>Successful Standing Order Response</returns>
        [Get("/standing-orders")]
        [Headers()] 
        Task<StandingOrdersGetAllResponse> StandingOrdersGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset,[Query][AliasAs("userId")] string userId);

        /// <summary>
        /// Retrieve a single payment
        /// </summary>
        /// <param name="standingOrderRequestId">The standing order request Id</param>
        /// <returns>Successful Standing Order Response</returns>
        [Get("/standing-orders/{standingOrderRequestId}")]
        [Headers()] 
        Task<StandingOrdersGetResponse> StandingOrdersGetAsync([AliasAs("standingOrderRequestId")] System.Guid standingOrderRequestId);

    }
}