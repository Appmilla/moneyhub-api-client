using System;
using System.Threading.Tasks;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    public interface IAccessToken
    {
        /// <summary>
        /// Get access token
        /// </summary>
        /// <returns>AccessTokenResponse</returns>
        [Post("/oidc/token")]
        [Headers("Content-Type: application/x-www-form-urlencoded")]
        Task<AccessTokenResponse> GetAccessToken([Body(BodySerializationMethod.UrlEncoded)][AliasAs("body")] AccessTokenRequest accessTokenRequest);
    }
}
