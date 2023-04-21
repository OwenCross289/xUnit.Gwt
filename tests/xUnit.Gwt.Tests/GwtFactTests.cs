namespace xUnit.Gwt.Tests;

public class GwtFactTests
{
    [GwtFact(
        given: "a GwtFactAttribute", 
        when: "the constructor is called", 
        then: "the DisplayName property is set")]
    public void T0()
    {
        var sut = new GwtFactAttribute(given: "a", when: "b", then: "c");
        sut.DisplayName.Should().Be("Given a. When b. Then c.");
    }
}