using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// AuthRequest
    /// </summary>    
    public class AuthRequest
    {
        /// <summary>
        /// The id of the auth request
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// The redirect uri sent when creating the auth request
        /// </summary>
        [AliasAs("redirectUri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// The date that the auth request was created.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("createdAt")]
        public System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The id of the bank
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("bankId")]
        public string BankId { get; set; }

        /// <summary>
        /// The id of the user
        /// </summary>
        [AliasAs("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// The scope sent when creating the auth request
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Id of the connection
        /// </summary>
        [AliasAs("connectionId")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Id of the payment when the auth request had the payment scope
        /// </summary>
        [AliasAs("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// The status of the auth request
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("status")]
        public AuthRequestStatus Status { get; set; }

    }
}