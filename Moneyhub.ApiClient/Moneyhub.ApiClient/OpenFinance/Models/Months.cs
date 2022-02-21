using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Months
    /// </summary>    
    public class Months
    {
        /// <summary>
        /// Date in the format YYYY-MM
        /// </summary>
        [AliasAs("date")]
        public string Date { get; set; }

        /// <summary>
        /// The opening balance in minor units of the currency, eg. pennies for GBP
        /// </summary>
        [AliasAs("openingBalance")]
        public int? OpeningBalance { get; set; }

        /// <summary>
        /// The non contribution growth in minor units of the currency, eg. pennies for GBP
        /// </summary>
        [AliasAs("nonContributionGrowth")]
        public double? NonContributionGrowth { get; set; }

        /// <summary>
        /// The aer expressed in percentage
        /// </summary>
        [AliasAs("aer")]
        public double? Aer { get; set; }

    }
}