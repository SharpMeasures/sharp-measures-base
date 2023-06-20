namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class AsIVector3Quantity_Y
{
    private static Scalar Target(Vector3 vector)
    {
        return execute(vector);

        static Scalar execute(IVector3Quantity quantity) => quantity.Y;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector3Y(Vector3 vector)
    {
        var expected = vector.Y;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
