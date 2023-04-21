namespace xUnit.Gwt.Tests;

public class GwtTheoryTests
{
    [GwtFact(
        given: "a GwtTheoryAttribute", 
        when: "the constructor is called", 
        then: "the DisplayName property is set")]
    public void T0()
    {
        var sut = new GwtTheoryAttribute(given: "a", when: "b", then: "c");
        sut.DisplayName.Should().Be("Given a. When b. Then c.");
    }
}