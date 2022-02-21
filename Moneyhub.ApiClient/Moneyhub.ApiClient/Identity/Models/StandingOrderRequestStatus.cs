namespace Appmilla.Moneyhub.Refit.Identity
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.26.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum StandingOrderRequestStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"InProgress")]
        InProgress = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"InitiationPending")]
        InitiationPending = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"InitiationFailed")]
        InitiationFailed = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"InitiationCompleted")]
        InitiationCompleted = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancelled")]
        Cancelled = 4,
    }
}