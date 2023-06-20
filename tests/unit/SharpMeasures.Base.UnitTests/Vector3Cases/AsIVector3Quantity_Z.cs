namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class AsIVector3Quantity_Z
{
    private static Scalar Target(Vector3 vector)
    {
        return execute(vector);

        static Scalar execute(IVector3Quantity quantity) => quantity.Z;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector3Z(Vector3 vector)
    {
        var expected = vector.Z;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
