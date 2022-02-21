using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// HoldingsValuation
    /// </summary>    
    public class HoldingsValuation
    {
        /// <summary>
        /// Date of the valuation
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("date")]
        public System.DateTimeOffset Date { get; set; }


        /// <summary>
        /// Items
        /// </summary> 
        [Required]

        [AliasAs("items")]
        public List<Items> Items { get; set; } = new List<Items>();

    }
}