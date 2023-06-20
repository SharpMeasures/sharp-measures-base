namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class ToValueTuple
{
    private static (Scalar, Scalar, Scalar, Scalar) Target(Vector4 vector) => vector.ToValueTuple();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsOfProvidedVector4(Vector4 vector)
    {
        var actual = Target(vector);

        Assert.Equal((vector.X, vector.Y, vector.Z, vector.W), actual);
    }
}
