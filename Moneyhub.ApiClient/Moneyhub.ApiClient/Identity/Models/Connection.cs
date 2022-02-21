using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Connection
    /// </summary>    
    public class Connection
    {
        /// <summary>
        /// Connection id composed of the bank id and unique connection id
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the connection
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// Connection type
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("type")]
        public ConnectionType Type { get; set; }

        /// <summary>
        /// The date the connection was created.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("connectedOn")]
        public System.DateTimeOffset ConnectedOn { get; set; }

        /// <summary>
        /// The date the connection was last updated.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("lastUpdated")]
        public System.DateTimeOffset LastUpdated { get; set; }

        /// <summary>
        /// The date the connection will expire.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("expiresAt")]
        public System.DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// Account ids that belong to the connection.
        /// </summary>
        [Required]
        [AliasAs("accountIds")]
        public List<string> AccountIds { get; set; } = new List<string>();

        /// <summary>
        /// Current status of the connection.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("status")]
        public ConnectionStatus Status { get; set; }

        /// <summary>
        /// Error code when the connection has the error status
        /// </summary>
        [AliasAs("error")]
        public ConnectionError? Error { get; set; }

    }
}