using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Meta
    /// </summary>    
    public class Meta
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
        /// Total
        /// </summary> 
        [Range(0, int.MaxValue)]
        [AliasAs("total")]
        public int? Total { get; set; }

    }
}