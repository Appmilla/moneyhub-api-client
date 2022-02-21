using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Holding
    /// </summary>    
    public class Holding
    {

        /// <summary>
        /// Codes
        /// </summary> 
        [Required]

        [AliasAs("codes")]
        public List<Codes> Codes { get; set; } = new List<Codes>();


        /// <summary>
        /// Description
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("description")]
        public string Description { get; set; }


        /// <summary>
        /// Quantity
        /// </summary> 

        [AliasAs("quantity")]
        public double Quantity { get; set; }


        /// <summary>
        /// Total
        /// </summary> 
        [Required]

        [AliasAs("total")]
        public Total Total { get; set; } = new Total();


        /// <summary>
        /// UnitPrice
        /// </summary> 
        [Required]

        [AliasAs("unitPrice")]
        public UnitPrice UnitPrice { get; set; } = new UnitPrice();

        /// <summary>
        /// The currency of the holding
        /// </summary>
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}