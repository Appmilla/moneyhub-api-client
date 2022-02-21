using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Matched
    /// </summary>    
    public class Matched
    {
        /// <summary>
        /// The ISIN code of the match
        /// </summary>
        [AliasAs("isin")]
        public string Isin { get; set; }

        /// <summary>
        /// The name of the match
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Score
        /// </summary> 

        [AliasAs("score")]
        public double? Score { get; set; }


        /// <summary>
        /// PriceGBP
        /// </summary> 

        [AliasAs("priceGBP")]
        public double? PriceGBP { get; set; }


        /// <summary>
        /// Price
        /// </summary> 

        [AliasAs("price")]
        public Price Price { get; set; }

        /// <summary>
        /// Date of the valuation
        /// </summary>
        [AliasAs("date")]
        public System.DateTimeOffset? Date { get; set; }

    }
}