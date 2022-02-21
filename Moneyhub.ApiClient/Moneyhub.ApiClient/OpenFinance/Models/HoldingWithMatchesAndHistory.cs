using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// HoldingWithMatchesAndHistory
    /// </summary>    
    public class HoldingWithMatchesAndHistory
    {
        /// <summary>
        /// The id of the holding
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Date of the valuation
        /// </summary>
        [AliasAs("date")]
        public System.DateTimeOffset? Date { get; set; }


        /// <summary>
        /// History
        /// </summary> 
        [Required]
        [AliasAs("history")]
        public List<History> History { get; set; } = new List<History>();


        /// <summary>
        /// Matched
        /// </summary> 
        [Required]
        [AliasAs("matched")]
        public List<Matched> Matched { get; set; } = new List<Matched>();


        /// <summary>
        /// Codes
        /// </summary> 
        [Required]
        [AliasAs("codes")]
        public List<Codes> Codes { get; set; } = new List<Codes>();


        /// <summary>
        /// Name
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("name")]
        public string Name { get; set; }


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

    }
}