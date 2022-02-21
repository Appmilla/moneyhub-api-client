using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SpendingGoalUpdateRequest
    /// </summary>    
    public class SpendingGoalUpdateRequest
    {
        /// <summary>
        /// The id of the category the spending goal should be created for
        /// </summary>
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public ValueAmount Amount { get; set; }

    }
}