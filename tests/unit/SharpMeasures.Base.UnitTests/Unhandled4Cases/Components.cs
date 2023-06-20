namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Components
{
    private static Vector4 Target(Unhandled4 vector) => vector.Components;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudesOfIndividualComponents(Unhandled4 vector)
    {
        Vector4 expected = (vector.X.Magnitude, vector.Y.Magnitude, vector.Z.Magnitude, vector.W.Magnitude);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
