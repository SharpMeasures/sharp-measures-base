namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class ToValueTuple
{
    private static (Unhandled, Unhandled) Target(Unhandled2 vector) => vector.ToValueTuple();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsOfProvidedUnhandled2(Unhandled2 vector)
    {
        var actual = Target(vector);

        Assert.Equal((vector.X, vector.Y), actual);
    }
}
