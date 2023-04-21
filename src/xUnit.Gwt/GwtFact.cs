namespace xUnit.Gwt;

public sealed class GwtFactAttribute : FactAttribute
{
    public GwtFactAttribute(string given, string when, string then)
    {
        DisplayName = $"Given {given}. When {when}. Then {then}.";
    }
}