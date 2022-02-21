using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Beneficiary
    /// </summary>    
    public class Beneficiary
    {
        /// <summary>
        /// The unique identifier for the beneficiary
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Shows whether the payee is currently active or not
        /// </summary>
        [AliasAs("active")]
        public bool Active { get; set; }

        /// <summary>
        /// The name for the beneficiary
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// The reference attached to the beneficiary
        /// </summary>
        [AliasAs("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The beneficiary's account number
        /// </summary>
        [AliasAs("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The beneficiary's sort code
        /// </summary>
        [AliasAs("sortCode")]
        public string SortCode { get; set; }

        /// <summary>
        /// For cash accounts. Populated with the full IBAN number.
        /// </summary>
        [StringLength(34, MinimumLength = 18)]
        [AliasAs("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// For card accounts. Populated with the Primary Account Number.
        /// </summary>
        [AliasAs("pan")]
        public string Pan { get; set; }

        /// <summary>
        /// The provider account ID the beneficiary belongs to
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("providerAccountId")]
        public string ProviderAccountId { get; set; }

        /// <summary>
        /// The provider beneficiary ID for the beneficiary
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("providerBeneficiaryId")]
        public string ProviderBeneficiaryId { get; set; }

        /// <summary>
        /// The Moneyhub account ID that the beneficiary belongs to
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Additional postal address information for the beneficiary agent, only retrieved using **beneficiaries_detail:read** scope
        /// </summary>
        [AliasAs("postalAddress")]
        public object PostalAddress { get; set; }

        /// <summary>
        /// The date at which the beneficiary was added.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("createdAt")]
        public System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The date at which the beneficiary was added.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("modifiedAt")]
        public System.DateTimeOffset ModifiedAt { get; set; }

    }
}