using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    public interface IConsents
    {
        /// <summary>
        /// Displays the internal consent screen for a given auth request
        /// </summary>
        /// <param name="authRequestId">The auth request Id</param>
        /// <returns>HTML response with configured internal consent screens for given auth request</returns>
        [Get("/consents/{authRequestId}")]
        [Headers()] 
        Task ConsentsAsync([AliasAs("authRequestId")] System.Guid authRequestId);

    }
}