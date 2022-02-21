using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// NotificationThreshold
    /// </summary>    
    public class NotificationThreshold
    {
        /// <summary>
        /// The value of the threshold in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [AliasAs("value")]
        public int? Value { get; set; }

        /// <summary>
        /// The type of threshold, either great than or less than
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("type")]
        public NotificationThresholdType Type { get; set; }

        /// <summary>
        /// The id of the threshold, used to update and delete it
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

    }
}