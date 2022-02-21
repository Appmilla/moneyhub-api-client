using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SpendingGoal
    /// </summary>    
    public class SpendingGoal
    {

        /// <summary>
        /// CategoryId
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }


        /// <summary>
        /// DateCreated
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("dateCreated")]
        public System.DateTimeOffset DateCreated { get; set; }


        /// <summary>
        /// PeriodType
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("periodType")]
        public SpendingGoalPeriodType PeriodType { get; set; }


        /// <summary>
        /// PeriodStart
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("periodStart")]
        public string PeriodStart { get; set; }

        /// <summary>
        /// The unique id of the spending goal
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 
        [Required]
        [AliasAs("amount")]
        public Amount Amount { get; set; } = new Amount();


        /// <summary>
        /// Spending
        /// </summary> 
        [Required]
        [AliasAs("spending")]
        public List<Spending> Spending { get; set; } = new List<Spending>();

    }
}