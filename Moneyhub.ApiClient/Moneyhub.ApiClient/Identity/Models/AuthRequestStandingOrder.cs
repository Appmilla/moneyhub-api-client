using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// StandingOrder2
    /// </summary>    
    public class AuthRequestStandingOrder
    {
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
        /// Payer Type
        /// </summary>
        [AliasAs("payerType")]
        public PaymentPayerType? PayerType { get; set; }

        /// <summary>
        /// The context of the payment
        /// </summary>
        [AliasAs("context")]
        public PaymentContext? Context { get; set; }

        /// <summary>
        /// The name or description given to the standing order
        /// </summary>
        [AliasAs("reference")]
        public string Reference { get; set; }


        /// <summary>
        /// Frequency
        /// </summary> 

        [AliasAs("frequency")]
        public Frequency Frequency { get; set; }

        /// <summary>
        /// The number of reucrring payments to complete the standing order
        /// </summary>
        [AliasAs("numberOfPayments")]
        public int? NumberOfPayments { get; set; }


        /// <summary>
        /// FirstPaymentDate
        /// </summary> 

        [AliasAs("firstPaymentDate")]
        public System.DateTimeOffset? FirstPaymentDate { get; set; }


        /// <summary>
        /// RecurringPaymentDate
        /// </summary> 

        [AliasAs("recurringPaymentDate")]
        public System.DateTimeOffset? RecurringPaymentDate { get; set; }


        /// <summary>
        /// FinalPaymentDate
        /// </summary> 

        [AliasAs("finalPaymentDate")]
        public System.DateTimeOffset? FinalPaymentDate { get; set; }

        /// <summary>
        /// The value of the first payment in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [AliasAs("firstPaymentAmount")]
        public int? FirstPaymentAmount { get; set; }

        /// <summary>
        /// The value of the next payment in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [AliasAs("recurringPaymentAmount")]
        public int? RecurringPaymentAmount { get; set; }

        /// <summary>
        /// The value of the final payment in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [AliasAs("finalPaymentAmount")]
        public int? FinalPaymentAmount { get; set; }

        /// <summary>
        /// The currency of the standing order
        /// </summary>
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}