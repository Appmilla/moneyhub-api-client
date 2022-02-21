using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SyncPost
    /// </summary>    
    public class SyncPost
    {
        /// <summary>
        /// The customer ip address if it is currently logged in
        /// </summary>
        [AliasAs("customerIpAddress")]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// The time when the customer last logged in represented as an ISO 8601 date-time format including timezone
        /// </summary>
        [AliasAs("customerLastLoggedTime")]
        public string CustomerLastLoggedTime { get; set; }

    }
}