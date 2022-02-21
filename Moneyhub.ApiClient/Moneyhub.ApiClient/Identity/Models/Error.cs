using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Error
    /// </summary>    
    public class Error
    {
        /// <summary>
        /// The error code
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("code")]
        public string Code { get; set; }

        /// <summary>
        /// The error message
        /// </summary>
        [AliasAs("message")]
        public string Message { get; set; }

        /// <summary>
        /// Id that identifies the request and can be used to ask for more details related to the error
        /// </summary>
        [AliasAs("correlationId")]
        public string CorrelationId { get; set; }

    }
}