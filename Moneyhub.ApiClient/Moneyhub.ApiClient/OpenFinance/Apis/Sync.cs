using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface ISync
    {
        /// <summary>
        /// Sync an existing connection
        /// </summary>
        /// <param name="connectionId">The connection id</param>
        /// <returns>Successful Sync Response</returns>
        [Post("/sync/{connectionId}")]
        [Headers()] 
        Task<SyncResponse> SyncAsync([AliasAs("connectionId")] string connectionId,[Body][AliasAs("body")] SyncPost body, [Header("Authorization")] string bearerToken);

    }
}