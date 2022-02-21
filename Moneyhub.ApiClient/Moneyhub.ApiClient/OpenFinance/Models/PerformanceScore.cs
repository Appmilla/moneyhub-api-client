using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Performance score of investment and pension accounts. Once that an account has at least 3 balances the score will be provided. Please note that this is an experimental feature.    /// </summary>    
    public class PerformanceScore
    {

        /// <summary>
        /// Totals
        /// </summary> 
        [Required]
        [AliasAs("totals")]
        public PerformanceTotals Totals { get; set; } = new PerformanceTotals();


        /// <summary>
        /// Months
        /// </summary> 
        [Required]
        [AliasAs("months")]
        public List<Months> Months { get; set; } = new List<Months>();

    }
}