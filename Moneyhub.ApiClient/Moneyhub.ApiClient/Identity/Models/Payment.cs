using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Payment
    /// </summary>    
    public class Payment
    {
        /// <summary>
        /// The id of the payment
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Payment amount in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [Range(1, 1000000)]
        [AliasAs("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Payee id
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("payeeId")]
        public string PayeeId { get; set; }

        /// <summary>
        /// Type of payee
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("payeeType")]
        public PaymentPayeeType PayeeType { get; set; }

        /// <summary>
        /// Payer Id
        /// </summary>
        [AliasAs("payerId")]
        public string PayerId { get; set; }

        /// <summary>
        /// Reference to display on payer's statement
        /// </summary>
        [Required]
        [StringLength(18, MinimumLength = 2)]

        [AliasAs("payerRef")]
        public string PayerRef { get; set; }

        /// <summary>
        /// Payer Type
        /// </summary>
        [AliasAs("payerType")]
        public PaymentPayerType? PayerType { get; set; }

        /// <summary>
        /// Payer name
        /// </summary>
        [StringLength(254, MinimumLength = 1)]
        [AliasAs("payerName")]
        public string PayerName { get; set; }

        /// <summary>
        /// Payer email
        /// </summary>
        [StringLength(254)]
        [AliasAs("payerEmail")]
        public string PayerEmail { get; set; }

        /// <summary>
        /// Currency code
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Determines if payment is refundable
        /// </summary>
        [AliasAs("isReversible")]
        public bool IsReversible { get; set; }

        /// <summary>
        /// The status of the payment
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("status")]
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// The status of the payment
        /// </summary>
        [AliasAs("providerStatus")]
        public string ProviderStatus { get; set; }

        /// <summary>
        /// Original payment submission id from financial institution
        /// </summary>
        [AliasAs("paymentSubmissionId")]
        public string PaymentSubmissionId { get; set; }

        /// <summary>
        /// List of payment charges
        /// </summary>
        [Required]
        [AliasAs("charges")]
        public List<Charges> Charges { get; set; } = new List<Charges>();

        /// <summary>
        /// The date that the payment was initiated
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("initiatedAt")]
        public System.DateTimeOffset InitiatedAt { get; set; }

        /// <summary>
        /// The date that the payment was finalised
        /// </summary>
        [AliasAs("finalisedAt")]
        public System.DateTimeOffset? FinalisedAt { get; set; }

    }
}