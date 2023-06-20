namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class AsIVectorQuantity_Magnitude
{
    private static Scalar Target(Vector2 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.Magnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector2Magnitude(Vector2 vector)
    {
        var expected = vector.Magnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
