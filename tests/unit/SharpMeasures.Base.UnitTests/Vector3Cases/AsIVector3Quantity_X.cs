namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class AsIVector3Quantity_X
{
    private static Scalar Target(Vector3 vector)
    {
        return execute(vector);

        static Scalar execute(IVector3Quantity quantity) => quantity.X;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector3X(Vector3 vector)
    {
        var expected = vector.X;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
