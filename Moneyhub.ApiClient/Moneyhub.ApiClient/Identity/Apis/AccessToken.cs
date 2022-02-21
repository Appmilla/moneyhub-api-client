using System;
using System.Threading.Tasks;
using Appmilla.Moneyhub.Refit.Appmilla.Moneyhub.Identity.Models;
using Refit;

namespace Appmilla.Moneyhub.Refit.Appmilla.Moneyhub.Identity.Apis
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
