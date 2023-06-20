namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Constructor_Unhandleds
{
    private static Unhandled4 Target(Unhandled x, Unhandled y, Unhandled z, Unhandled w) => new(x, y, z, w);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled4_EqualsProvidedUnhandled4(Unhandled4 vector)
    {
        var actual = Target(vector.X, vector.Y, vector.Z, vector.W);

        Assert.Equal(vector, actual);
    }
}
