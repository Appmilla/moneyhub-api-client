using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// CurrentBalance
    /// </summary>    
    public class CurrentBalance
    {

        /// <summary>
        /// Date
        /// </summary> 

        [AliasAs("date")]
        public System.DateTimeOffset? Date { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public Amount Amount { get; set; }

    }
}