using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// GlobalCounterparty
    /// </summary>    
    public class GlobalCounterparty
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
        /// The full name of the company (only for global counterparties)
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// The url to the company logo (only for global counterparties)
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// The url to the company website (only for global counterparties)
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("website")]
        public string Website { get; set; }


        /// <summary>
        /// Mcc
        /// </summary> 
        [Required]
        [AliasAs("mcc")]
        public Mcc Mcc { get; set; } = new Mcc();

    }
}