using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Counterparty
    /// </summary>    
    public class Counterparty
    {
        /// <summary>
        /// The unique identifier for the counterparty.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// A label describing the counterparty
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("label")]
        public string Label { get; set; }

        /// <summary>
        /// The type of counterparty (specific to an account, or globally recognised across all users)
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("type")]
        public CounterpartyType Type { get; set; }

        /// <summary>
        /// The full name of the company (only for global counterparties)
        /// </summary>
        [AliasAs("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// The url to the company logo (only for global counterparties)
        /// </summary>
        [AliasAs("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// The url to the company website (only for global counterparties)
        /// </summary>
        [AliasAs("website")]
        public string Website { get; set; }


        /// <summary>
        /// Mcc
        /// </summary> 
        [AliasAs("mcc")]
        public Mcc Mcc { get; set; }

    }
}