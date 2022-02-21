using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// TransactionDetails
    /// </summary>    
    public class TransactionDetails
    {

        /// <summary>
        /// Count
        /// </summary> 

        [AliasAs("count")]
        public int Count { get; set; }


        /// <summary>
        /// EarliestDate
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("earliestDate")]
        public System.DateTimeOffset EarliestDate { get; set; }


        /// <summary>
        /// LastDate
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("lastDate")]
        public System.DateTimeOffset LastDate { get; set; }

    }
}