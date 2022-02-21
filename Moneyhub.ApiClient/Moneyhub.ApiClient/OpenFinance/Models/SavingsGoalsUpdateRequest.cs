using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SavingsGoalsUpdateRequest
    /// </summary>    
    public class SavingsGoalsUpdateRequest
    {
        /// <summary>
        /// Name for the savings goal.
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public ValueAmount Amount { get; set; }


        /// <summary>
        /// ImageUrl
        /// </summary> 

        [AliasAs("imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Arbitrary text that a user can add about a savings goal.
        /// </summary>
        [AliasAs("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Accounts that will be taken into account towards the target amount.
        /// </summary>
        [MinLength(1)]
        [AliasAs("accounts")]
        public List<Accounts> Accounts { get; set; }

    }
}