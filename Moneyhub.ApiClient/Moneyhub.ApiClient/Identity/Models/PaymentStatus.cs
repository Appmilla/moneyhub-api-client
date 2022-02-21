[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.26.0 (Newtonsoft.Json v9.0.0.0)")]
public enum PaymentStatus
{
    [System.Runtime.Serialization.EnumMember(Value = @"inProgress")]
    InProgress = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"pending")]
    Pending = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"completed")]
    Completed = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"cancelled")]
    Cancelled = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"rejected")]
    Rejected = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"abandoned")]
    Abandoned = 5,

    [System.Runtime.Serialization.EnumMember(Value = @"error:paymentSubmission")]
    ErrorPaymentSubmission = 6,

    [System.Runtime.Serialization.EnumMember(Value = @"error:redirect")]
    ErrorRedirect = 7,

    [System.Runtime.Serialization.EnumMember(Value = @"error:tokenGrant")]
    ErrorTokenGrant = 8,

}