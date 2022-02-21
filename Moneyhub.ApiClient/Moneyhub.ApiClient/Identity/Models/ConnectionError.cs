namespace Appmilla.Moneyhub.Refit.Identity
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.26.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ConnectionError
    {
        [System.Runtime.Serialization.EnumMember(Value = @"resync")]
        Resync = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"sync_error")]
        Sync_error = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"sync_partial")]
        Sync_partial = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"mfa_required")]
        Mfa_required = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"credentials_error")]
        Credentials_error = 4,
    }
}