namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Components
{
    private static Vector3 Target(Unhandled3 vector) => vector.Components;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudesOfIndividualComponents(Unhandled3 vector)
    {
        Vector3 expected = (vector.X.Magnitude, vector.Y.Magnitude, vector.Z.Magnitude);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
