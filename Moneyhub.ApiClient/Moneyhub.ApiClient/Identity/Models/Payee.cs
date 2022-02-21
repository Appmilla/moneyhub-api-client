using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Payee
    /// </summary>    
    public class Payee
    {
        /// <summary>
        /// The id of the payee
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// The id of the client
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// The sort code of the payee
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("sortCode")]
        public string SortCode { get; set; }

        /// <summary>
        /// The account number of the payee
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The date that the payee was created.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("createdAt")]
        public System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The date that the payee was modified.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("modifiedAt")]
        public System.DateTimeOffset ModifiedAt { get; set; }

        /// <summary>
        /// Determines if payee is active
        /// </summary>
        [AliasAs("active")]
        public bool Active { get; set; }

        /// <summary>
        /// The name of the payee
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// External ID of the payee
        /// </summary>
        [StringLength(64)]
        [AliasAs("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// User ID of the payee
        /// </summary>
        [StringLength(64)]
        [AliasAs("userId")]
        public string UserId { get; set; }

    }
}