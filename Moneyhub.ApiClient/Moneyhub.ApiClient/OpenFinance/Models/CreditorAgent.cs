using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// CreditorAgent
    /// </summary>    
    public class CreditorAgent
    {
        /// <summary>
        /// Name by which an agent is known and which is usually used to identify that agent.
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// The postal address for the financial institution
        /// </summary>
        [AliasAs("postalAddress")]
        public object PostalAddress { get; set; }

    }
}