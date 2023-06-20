namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class ToValueTuple
{
    private static (Unhandled, Unhandled, Unhandled) Target(Unhandled3 vector) => vector.ToValueTuple();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsOfProvidedUnhandled3(Unhandled3 vector)
    {
        var actual = Target(vector);

        Assert.Equal((vector.X, vector.Y, vector.Z), actual);
    }
}
