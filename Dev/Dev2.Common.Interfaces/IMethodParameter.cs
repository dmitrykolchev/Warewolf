namespace Dev2.Common.Interfaces
{
    public interface IMethodParameter
    {
        string Name { get; set; }
        bool EmptyToNull { get; set; }
        bool IsRequired { get; set; }
        string Value { get; set; }
        string DefaultValue { get; set; }
        string TypeName { get; set; }
    }
}