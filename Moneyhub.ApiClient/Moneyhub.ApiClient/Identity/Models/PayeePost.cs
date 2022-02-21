using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// PayeePost
    /// </summary>    
    public class PayeeCreateRequest
    {
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