using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// StandingOrderRequest
    /// </summary>    
    public class StandingOrderRequest
    {
        /// <summary>
        /// The id of the standing order request
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// Status
        /// </summary> 
        [AliasAs("status")]
        public StandingOrderRequestStatus? Status { get; set; }

        /// <summary>
        /// The date that the standing order was created
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("createdAt")]
        public System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The date that the standing order was last updated
        /// </summary>
        [AliasAs("updatedAt")]
        public System.DateTimeOffset? UpdatedAt { get; set; }


        /// <summary>
        /// StandingOrder
        /// </summary> 
        [Required]
        [AliasAs("standingOrder")]
        public StandingOrder StandingOrder { get; set; } = new StandingOrder();

    }
}