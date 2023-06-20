namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class AsIVector2Quantity_X
{
    private static Scalar Target(Vector2 vector)
    {
        return execute(vector);

        static Scalar execute(IVector2Quantity quantity) => quantity.X;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector2X(Vector2 vector)
    {
        var expected = vector.X;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
