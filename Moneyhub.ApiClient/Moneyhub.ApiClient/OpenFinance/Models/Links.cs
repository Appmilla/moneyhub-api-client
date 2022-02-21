using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Links
    /// </summary>    
    public class Links
    {
        /// <summary>
        /// The url to retrieve the next page of results from
        /// </summary>
        [AliasAs("next")]
        public System.Uri Next { get; set; }

        /// <summary>
        /// The url to retrieve the previous page of results from
        /// </summary>
        [AliasAs("prev")]
        public System.Uri Prev { get; set; }

        /// <summary>
        /// The url of the current resource(s)
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("self")]
        public System.Uri Self { get; set; }

    }
}