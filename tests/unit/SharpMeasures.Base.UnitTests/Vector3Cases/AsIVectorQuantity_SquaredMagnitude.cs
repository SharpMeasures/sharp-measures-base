namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class AsIVectorQuantity_SquaredMagnitude
{
    private static Scalar Target(Vector3 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.SquaredMagnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector3SquaredMagnitude(Vector3 vector)
    {
        var expected = vector.SquaredMagnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
