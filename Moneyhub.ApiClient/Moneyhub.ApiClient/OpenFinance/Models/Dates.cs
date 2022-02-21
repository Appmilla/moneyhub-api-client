using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Dates
    /// </summary>    
    public class Dates
    {
        /// <summary>
        /// Descriptive name for the date range. The name will be used in the response payload to identify it.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// Start date to perform spending analysis.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("from")]
        public System.DateTimeOffset From { get; set; }

        /// <summary>
        /// End date to perform spending analysis.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("to")]
        public System.DateTimeOffset To { get; set; }

    }
}