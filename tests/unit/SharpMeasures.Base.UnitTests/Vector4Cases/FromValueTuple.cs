namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class FromValueTuple
{
    private static Vector4 Target((Scalar, Scalar, Scalar, Scalar) components) => Vector4.FromValueTuple(components);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedVector4_EqualsProvidedVector4(Vector4 vector)
    {
        var actual = Target((vector.X, vector.Y, vector.Z, vector.W));

        Assert.Equal(vector, actual);
    }
}
