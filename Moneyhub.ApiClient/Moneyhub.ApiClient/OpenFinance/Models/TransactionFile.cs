using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// TransactionFile
    /// </summary>    
    public class TransactionFile
    {
        /// <summary>
        /// The id of the file attached to the transaction
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// The MIME type of the file
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("fileType")]
        public string FileType { get; set; }

        /// <summary>
        /// The name of the file attachment
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// The signed URL that is valid for 5 minutes that allows access to the attachment
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("url")]
        public string Url { get; set; }

    }
}