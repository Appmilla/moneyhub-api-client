using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response8
    /// </summary>    
    public class AuthRequestsGetResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public AuthRequest Data { get; set; }


        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public object Meta { get; set; }

    }
}