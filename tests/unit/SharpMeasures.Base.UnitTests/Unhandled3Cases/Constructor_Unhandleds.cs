namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Constructor_Unhandleds
{
    private static Unhandled3 Target(Unhandled x, Unhandled y, Unhandled z) => new(x, y, z);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled3_EqualsProvidedUnhandled3(Unhandled3 vector)
    {
        var actual = Target(vector.X, vector.Y, vector.Z);

        Assert.Equal(vector, actual);
    }
}
