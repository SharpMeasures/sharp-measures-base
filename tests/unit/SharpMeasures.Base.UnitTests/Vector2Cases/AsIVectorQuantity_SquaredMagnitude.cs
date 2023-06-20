namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class AsIVectorQuantity_SquaredMagnitude
{
    private static Scalar Target(Vector2 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.SquaredMagnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector2SquaredMagnitude(Vector2 vector)
    {
        var expected = vector.SquaredMagnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
