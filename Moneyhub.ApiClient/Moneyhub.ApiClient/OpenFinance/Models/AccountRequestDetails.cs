using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// AccountRequestDetails
    /// </summary>    
    public class AccountRequestDetails
    {
        /// <summary>
        /// For cash and savings accounts. Interest rate expressed as a percentage 'Annual Equivalent Rate'.
        /// </summary>
        [Range(0D, 100D)]
        [AliasAs("AER")]
        public double? AER { get; set; }

        /// <summary>
        /// For credit cards, mortgages and loans. Interest rate expressed as a percentage 'Annual Percentage Rate'.
        /// </summary>
        [Range(0D, 100D)]
        [AliasAs("APR")]
        public double? APR { get; set; }

        /// <summary>
        /// For credit cards. The agreed overdraft limit of the account in minor units of the currency.
        /// </summary>
        [Range(0, int.MaxValue)]
        [AliasAs("creditLimit")]
        public int? CreditLimit { get; set; }

        /// <summary>
        /// For Mortgages and loans. The date at which the loan/mortgage will finish.
        /// </summary>
        [AliasAs("endDate")]
        public System.DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// For Mortgages. The date at which the current fixed rate ends
        /// </summary>
        [AliasAs("fixedDate")]
        public System.DateTimeOffset? FixedDate { get; set; }

        /// <summary>
        /// For loans. The length in months of the interest free period
        /// </summary>
        [Range(0, int.MaxValue)]
        [AliasAs("interestFreePeriod")]
        public int? InterestFreePeriod { get; set; }

        /// <summary>
        /// For mortgages. The interest type
        /// </summary>
        [AliasAs("interestType")]
        public DetailsInterestType? InterestType { get; set; }

        /// <summary>
        /// For Mortgages. The id of an associated property account
        /// </summary>
        [AliasAs("linkedProperty")]
        public string LinkedProperty { get; set; }

        /// <summary>
        /// For mortgages and loans. The monthly amount due to the mortgage provider in minor units of the currency.
        /// </summary>
        [Range(0, int.MaxValue)]
        [AliasAs("monthlyRepayment")]
        public int? MonthlyRepayment { get; set; }

        /// <summary>
        /// For cash accounts. The agreed overdraft limit of the account in minor units of the currency.
        /// </summary>
        [Range(0D, double.MaxValue)]
        [AliasAs("overdraftLimit")]
        public double? OverdraftLimit { get; set; }

        /// <summary>
        /// For properties. The postcode of the property
        /// </summary>
        [AliasAs("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// For assets. The running cost in minor units of the currency.
        /// </summary>
        [Range(0, int.MaxValue)]
        [AliasAs("runningCost")]
        public int? RunningCost { get; set; }

        /// <summary>
        /// For assets. The running cost period
        /// </summary>
        [AliasAs("runningCostPeriod")]
        public DetailsRunningCostPeriod? RunningCostPeriod { get; set; }

        /// <summary>
        /// For mortgages. The term of the mortgage in months.
        /// </summary>
        [Range(0, int.MaxValue)]
        [AliasAs("term")]
        public int? Term { get; set; }

        /// <summary>
        /// For assets. The rate of appreciation as a percentage, negative values indicate that the asset will depreciate
        /// </summary>
        [AliasAs("yearlyAppreciation")]
        public double? YearlyAppreciation { get; set; }

    }
}