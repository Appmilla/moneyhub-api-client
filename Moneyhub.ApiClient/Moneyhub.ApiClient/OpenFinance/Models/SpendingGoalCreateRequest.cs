using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SpendingGoalCreateRequest
    /// </summary>    
    public class SpendingGoalCreateRequest
    {
        /// <summary>
        /// The id of the category for the spending goal, either from the /categories endpoint or **std:all**
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// The period type of the goal, can be annual or monthly
        /// </summary>
        [AliasAs("periodType")]
        public SpendingGoalPostPeriodType? PeriodType { get; set; }

        /// <summary>
        /// You can set a goal period to start on a certain date. DD when periodType is monthly, DD-MM when periodType is annual
        /// </summary>
        [AliasAs("periodStart")]
        public string PeriodStart { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 
        [Required]
        [AliasAs("amount")]
        public ValueAmount Amount { get; set; } = new ValueAmount();

    }
}