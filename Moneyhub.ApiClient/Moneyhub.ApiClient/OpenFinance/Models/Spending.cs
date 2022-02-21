using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Spending
    /// </summary>    
    public class Spending
    {

        /// <summary>
        /// Date
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("date")]
        public string Date { get; set; }

        /// <summary>
        /// The spending analysis amount of the specified month expressed in minor units of the currency.
        /// </summary>
        [AliasAs("spent")]
        public int Spent { get; set; }

    }
}