using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// QueryParams
    /// </summary>    
    public class QueryParams
    {

        /// <summary>
        /// Limit
        /// </summary> 
        [Range(0, 1000)]

        [AliasAs("limit")]
        public int? Limit { get; set; }


        /// <summary>
        /// Offset
        /// </summary> 
        [Range(0, 1000000000)]

        [AliasAs("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// User ID of the payee
        /// </summary>
        [StringLength(64)]
        [AliasAs("userId")]
        public string UserId { get; set; }

    }
}