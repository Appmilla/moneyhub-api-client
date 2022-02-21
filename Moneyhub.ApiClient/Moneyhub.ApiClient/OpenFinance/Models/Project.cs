using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Project
    /// </summary>    
    public class Project
    {
        /// <summary>
        /// The unique identifier for the project
        /// </summary>
        [Required]
        [AliasAs("id")]
        public object Id { get; set; }

        /// <summary>
        /// The name of the project
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// Account IDs that are associated with the project
        /// </summary>
        [Required]
        [AliasAs("accountIds")]
        public List<string> AccountIds { get; set; } = new List<string>();

        /// <summary>
        /// The project type
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("type")]
        public ProjectType Type { get; set; }

        /// <summary>
        /// The date the project was created
        /// </summary>
        [AliasAs("dateCreated")]
        public System.DateTimeOffset? DateCreated { get; set; }

        /// <summary>
        /// Flag to show if project is archived or not
        /// </summary>
        [AliasAs("archived")]
        public bool? Archived { get; set; }

    }
}