namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Components
{
    private static Vector2 Target(Unhandled2 vector) => vector.Components;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudesOfIndividualComponents(Unhandled2 vector)
    {
        Vector2 expected = (vector.X.Magnitude, vector.Y.Magnitude);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
