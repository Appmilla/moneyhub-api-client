using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SavingsGoalsCreateRequest
    /// </summary>    
    public class SavingsGoalsCreateRequest
    {
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
        [Required]
        [MinLength(1)]
        [AliasAs("accounts")]
        public List<Accounts> Accounts { get; set; } = new List<Accounts>();

    }
}