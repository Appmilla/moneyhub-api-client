using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// RedirectParams
    /// </summary>    
    public class RedirectParams
    {
        /// <summary>
        /// The url at the financial institution to redirect the user towards
        /// </summary>
        [AliasAs("authUrl")]
        public string AuthUrl { get; set; }

        /// <summary>
        /// The url that the user will be returned to afer they have authorized
        /// </summary>
        [AliasAs("returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The `state` params that will be included in the query params or hash fragment when the user is redirected back
        /// </summary>
        [AliasAs("state")]
        public string State { get; set; }

    }
}