using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// AuthRequestPost
    /// </summary>    
    public class AuthRequestCreateRequest
    {
        /// <summary>
        /// One of the redirect uri that is set up under your API client. Required until separate bank registration is complete
        /// </summary>
        [AliasAs("redirectUri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// The id of the user. Required for second use case - account access.
        /// </summary>
        [AliasAs("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// The scope for the auth request
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// The connection id. Required when scope has 'reauth' or 'refresh'
        /// </summary>
        [AliasAs("connectionId")]
        public string ConnectionId { get; set; }


        /// <summary>
        /// Payment
        /// </summary> 

        [AliasAs("payment")]
        public AuthRequestPayment Payment { get; set; }


        /// <summary>
        /// StandingOrder
        /// </summary> 

        [AliasAs("standingOrder")]
        public AuthRequestStandingOrder StandingOrder { get; set; }


        /// <summary>
        /// ReversePayment
        /// </summary> 

        [AliasAs("reversePayment")]
        public ReversePayment ReversePayment { get; set; }

        /// <summary>
        /// Type of transaction categorisation to use. Defaults to personal categories
        /// </summary>
        [AliasAs("categorisationType")]
        public AuthRequestCategorisationType? CategorisationType { get; set; }

    }
}