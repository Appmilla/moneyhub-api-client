using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SpendingAnalysis
    /// </summary>    
    public class SpendingAnalysis
    {
        /// <summary>
        /// Array of categories showing the outgoing expenditure for the given period requested
        /// </summary>
        [Required]
        [AliasAs("categories")]
        public List<Categories> Categories { get; set; } = new List<Categories>();

        /// <summary>
        /// Total outgoing expenditure for the given periods. This calculation do not include income and transfers
        /// </summary>
        [Required]
        [AliasAs("total")]
        public object Total { get; set; } = new object();

    }
}