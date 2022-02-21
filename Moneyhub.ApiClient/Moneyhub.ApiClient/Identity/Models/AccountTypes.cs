using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// AccountTypes
    /// </summary>    
    public class AccountTypes
    {
        /// <summary>
        /// A beta boolean value flagging which accounts types for that connection are currently being developed and may not have a 100% success rate
        /// </summary>
        [AliasAs("beta")]
        public bool? Beta { get; set; }

        /// <summary>
        /// Type of account
        /// </summary>
        [AliasAs("name")]
        public AccountTypesName? Name { get; set; }

    }
}