namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class ToValueTuple
{
    private static (Unhandled, Unhandled, Unhandled, Unhandled) Target(Unhandled4 vector) => vector.ToValueTuple();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsOfProvidedUnhandled4(Unhandled4 vector)
    {
        var actual = Target(vector);

        Assert.Equal((vector.X, vector.Y, vector.Z, vector.W), actual);
    }
}
