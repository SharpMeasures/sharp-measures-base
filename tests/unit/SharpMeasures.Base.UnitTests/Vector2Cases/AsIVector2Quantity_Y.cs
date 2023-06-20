namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class AsIVector2Quantity_Y
{
    private static Scalar Target(Vector2 vector)
    {
        return execute(vector);

        static Scalar execute(IVector2Quantity quantity) => quantity.Y;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector2Y(Vector2 vector)
    {
        var expected = vector.Y;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
