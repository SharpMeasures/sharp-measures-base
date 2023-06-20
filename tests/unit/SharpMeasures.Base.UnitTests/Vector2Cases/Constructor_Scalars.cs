namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Constructor_Scalars
{
    private static Vector2 Target(Scalar x, Scalar y) => new(x, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedVector2_EqualsProvidedVector2(Vector2 vector)
    {
        var actual = Target(vector.X, vector.Y);

        Assert.Equal(vector, actual);
    }
}
