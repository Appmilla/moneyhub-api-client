using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// AuthParams
    /// </summary>    
    public class AuthParams
    {
        /// <summary>
        /// State returned by financial institution
        /// </summary>
        [AliasAs("state")]
        public string State { get; set; }

        /// <summary>
        /// Authorization code returned by financial institution
        /// </summary>
        [AliasAs("code")]
        public string Code { get; set; }

        /// <summary>
        /// Id token returned by financial institution
        /// </summary>
        [AliasAs("id_token")]
        public string Id_token { get; set; }

        /// <summary>
        /// Error returned by financial institution
        /// </summary>
        [AliasAs("error")]
        public string Error { get; set; }

        /// <summary>
        /// Error description returned by financial institution
        /// </summary>
        [AliasAs("error_description")]
        public string Error_description { get; set; }

    }
}