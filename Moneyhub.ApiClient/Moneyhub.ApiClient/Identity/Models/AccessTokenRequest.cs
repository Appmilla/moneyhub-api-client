using System;
using Refit;

namespace Appmilla.Moneyhub.Refit.Appmilla.Moneyhub.Identity.Models
{
    public class AccessTokenRequest
    {
        [AliasAs("scope")]
        public string Scope { get; set; }

        [AliasAs("grant_type")]
        public string GrantType { get; set; }

        [AliasAs("sub")]
        public string Sub { get; set; }
    }
}
