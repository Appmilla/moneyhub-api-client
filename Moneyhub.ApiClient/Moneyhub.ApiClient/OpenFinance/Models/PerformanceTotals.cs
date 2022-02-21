using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// PerformanceTotals
    /// </summary>    
    public class PerformanceTotals
    {

        /// <summary>
        /// OpeningBalance
        /// </summary> 

        [AliasAs("openingBalance")]
        public OpeningBalance OpeningBalance { get; set; }


        /// <summary>
        /// CurrentBalance
        /// </summary> 

        [AliasAs("currentBalance")]
        public CurrentBalance CurrentBalance { get; set; }

        /// <summary>
        /// The contributions in minor units of the currency, eg. pennies for GBP
        /// </summary>
        [AliasAs("contributions")]
        public int? Contributions { get; set; }

        /// <summary>
        /// The withdrawals in minor units of the currency, eg. pennies for GBP
        /// </summary>
        [AliasAs("withdrawals")]
        public int? Withdrawals { get; set; }

        /// <summary>
        /// The non contribution growth in minor units of the currency, eg. pennies for GBP
        /// </summary>
        [AliasAs("nonContributionGrowth")]
        public int? NonContributionGrowth { get; set; }

        /// <summary>
        /// The growth rate expressed in percentage
        /// </summary>
        [AliasAs("growthRate")]
        public double? GrowthRate { get; set; }

        /// <summary>
        /// The annualised growth rate expressed in percentage
        /// </summary>
        [AliasAs("annualisedGrowthRate")]
        public double? AnnualisedGrowthRate { get; set; }

    }
}