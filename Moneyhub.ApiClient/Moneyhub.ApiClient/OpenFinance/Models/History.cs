using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// History
    /// </summary>    
    public class History
    {

        /// <summary>
        /// Total
        /// </summary> 

        [AliasAs("total")]
        public Total Total { get; set; }


        /// <summary>
        /// UnitPrice
        /// </summary> 

        [AliasAs("unitPrice")]
        public UnitPrice UnitPrice { get; set; }


        /// <summary>
        /// Quantity
        /// </summary> 

        [AliasAs("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Date of the valuation
        /// </summary>
        [AliasAs("date")]
        public System.DateTimeOffset? Date { get; set; }

    }
}