namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Constructor_Unhandleds
{
    private static Unhandled2 Target(Unhandled x, Unhandled y) => new(x, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled2_EqualsProvidedUnhandled2(Unhandled2 vector)
    {
        var actual = Target(vector.X, vector.Y);

        Assert.Equal(vector, actual);
    }
}
