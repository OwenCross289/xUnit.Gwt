namespace xUnit.Gwt;

public sealed class GwtTheoryAttribute : TheoryAttribute
{
    public GwtTheoryAttribute(string given, string when, string then)
    {
        DisplayName = $"Given {given}. When {when}. Then {then}.";
    }
}