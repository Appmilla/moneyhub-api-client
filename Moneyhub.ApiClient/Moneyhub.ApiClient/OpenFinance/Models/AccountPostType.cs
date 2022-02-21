namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.26.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum AccountPostType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"cash:current")]
        CashCurrent = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"savings")]
        Savings = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"card")]
        Card = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"investment")]
        Investment = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"loan")]
        Loan = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"mortgage:repayment")]
        MortgageRepayment = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"mortgage:interestOnly")]
        MortgageInterestOnly = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"pension")]
        Pension = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"pension:definedBenefit")]
        PensionDefinedBenefit = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"pension:definedContribution")]
        PensionDefinedContribution = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"asset")]
        Asset = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"properties:residential")]
        PropertiesResidential = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"properties:buyToLet")]
        PropertiesBuyToLet = 12,
    }
}