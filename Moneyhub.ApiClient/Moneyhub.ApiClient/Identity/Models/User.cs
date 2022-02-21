using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// User
    /// </summary>    
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Id specified by API client on user's creation
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]

        [AliasAs("clientUserId")]
        public string ClientUserId { get; set; }

        /// <summary>
        /// API client Id that created the user
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// The date the user was created
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("createdAt")]
        public System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The date the user was last updated
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("updatedAt")]
        public System.DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Scope used when the user was created
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("scopes")]
        public string Scopes { get; set; }

        /// <summary>
        /// Represents how the user was created. Managed by client means that the api client created the user before hand according our second use case. Managed by user means that the user was created automatically when creating a connection according our first use case
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("managedBy")]
        public UserManagedBy ManagedBy { get; set; }

        /// <summary>
        /// The date the user was last accessed. This property gets updated everytime a token is issued for this user
        /// </summary>
        [AliasAs("lastAccessed")]
        public string LastAccessed { get; set; }

        /// <summary>
        /// The date the user was deleted
        /// </summary>
        [AliasAs("deletedAt")]
        public string DeletedAt { get; set; }

        /// <summary>
        /// The type of user
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("userType")]
        public UserType UserType { get; set; }

        /// <summary>
        /// Name of the api client that created the user
        /// </summary>
        [StringLength(256)]
        [AliasAs("clientName")]
        public string ClientName { get; set; }

        /// <summary>
        /// List of connection ids for the user
        /// </summary>
        [Required]
        [AliasAs("connectionIds")]
        public List<string> ConnectionIds { get; set; } = new List<string>();

    }
}