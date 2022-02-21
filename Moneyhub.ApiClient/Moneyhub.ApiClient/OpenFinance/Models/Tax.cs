using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Tax
    /// </summary>    
    public class Tax
    {
        /// <summary>
        /// The date the transactions are from
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("dateFrom")]
        public System.DateTimeOffset DateFrom { get; set; }

        /// <summary>
        /// The date the transactions are to
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("dateTo")]
        public System.DateTimeOffset DateTo { get; set; }

        /// <summary>
        /// The calculated tax return amounts.
        /// </summary>
        [Required]
        [AliasAs("taxReturn")]
        public TaxReturn TaxReturn { get; set; } = new TaxReturn();

    }
}