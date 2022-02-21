using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// UserPost
    /// </summary>    
    public class UserCreateRequest
    {
        /// <summary>
        /// Optional Id specified by API client on user's creation
        /// </summary>
        [StringLength(256)]
        [AliasAs("clientUserId")]
        public string ClientUserId { get; set; }

    }
}