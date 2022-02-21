using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// AuthRequestPatch
    /// </summary>    
    public class AuthRequestUpdateRequest
    {

        /// <summary>
        /// AuthParams
        /// </summary> 
        [Required]

        [AliasAs("authParams")]
        public AuthParams AuthParams { get; set; } = new AuthParams();

    }
}