using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SavingsGoals
    /// </summary>    
    public class SavingsGoals
    {
        /// <summary>
        /// Unique id of the saving goal.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name for the savings goal.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 
        [Required]
        [AliasAs("amount")]
        public Amount Amount { get; set; } = new Amount();

        /// <summary>
        /// The date at which the savings goal was added.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("dateCreated")]
        public System.DateTimeOffset DateCreated { get; set; }

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
        /// Progress achieved towards the target amount represented in percentage.
        /// </summary>
        [AliasAs("progressPercentage")]
        public double? ProgressPercentage { get; set; }

        /// <summary>
        /// Progress achieved towards the target amount by adding up the balances of the selected accounts.
        /// </summary>
        [AliasAs("progressAmount")]
        public int? ProgressAmount { get; set; }

        /// <summary>
        /// Accounts that will be taken into account towards the target amount.
        /// </summary>
        [Required]
        [MinLength(1)]
        [AliasAs("accounts")]
        public List<Accounts> Accounts { get; set; } = new List<Accounts>();

    }
}