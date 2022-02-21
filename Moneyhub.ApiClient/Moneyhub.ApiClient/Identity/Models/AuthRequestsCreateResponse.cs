using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response7
    /// </summary>    
    public class AuthRequestsCreateResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public AuthRequestCreate AuthRequestCreate { get; set; }


        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public object Meta { get; set; }

    }
}