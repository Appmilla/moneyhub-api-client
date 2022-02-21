using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// ReversePayment
    /// </summary>    
    public class ReversePayment
    {
        /// <summary>
        /// The id of the payment to reverse
        /// </summary>
        [AliasAs("paymentId")]
        public string PaymentId { get; set; }

    }
}