using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// CardInstrument
    /// </summary>    
    public class CardInstrument
    {
        /// <summary>
        /// Name of the cardholder using the card instrument.
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// The PAN of the card used in the transaction. This is known by the account owner, and may be masked.
        /// </summary>
        [AliasAs("pan")]
        public string Pan { get; set; }

        /// <summary>
        /// Name of the card scheme.
        /// </summary>
        [AliasAs("cardSchemeName")]
        public string CardSchemeName { get; set; }

        /// <summary>
        /// The card authorisation type.
        /// </summary>
        [AliasAs("authorisationType")]
        public string AuthorisationType { get; set; }

    }
}