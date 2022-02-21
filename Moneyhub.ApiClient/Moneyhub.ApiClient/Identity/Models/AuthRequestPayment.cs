using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Payment2
    /// </summary>    
    public class AuthRequestPayment
    {
        /// <summary>
        /// Payment amount in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [Range(1, 1000000)]
        [AliasAs("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Payee id
        /// </summary>
        [AliasAs("payeeId")]
        public string PayeeId { get; set; }

        /// <summary>
        /// Type of payee
        /// </summary>
        [AliasAs("payeeType")]
        public PaymentPayeeType? PayeeType { get; set; }

        /// <summary>
        /// Payer Id
        /// </summary>
        [AliasAs("payerId")]
        public string PayerId { get; set; }

        /// <summary>
        /// Reference to display on payer's statement
        /// </summary>
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
        /// Determines whether to read the refund account details
        /// </summary>
        [AliasAs("readRefundAccount")]
        public bool? ReadRefundAccount { get; set; }

        /// <summary>
        /// The context of the payment
        /// </summary>
        [AliasAs("context")]
        public PaymentContext? Context { get; set; }

    }
}