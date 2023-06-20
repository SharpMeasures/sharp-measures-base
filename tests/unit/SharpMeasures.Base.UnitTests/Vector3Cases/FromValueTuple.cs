namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class FromValueTuple
{
    private static Vector3 Target((Scalar, Scalar, Scalar) components) => Vector3.FromValueTuple(components);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedVector3_EqualsProvidedVector3(Vector3 vector)
    {
        var actual = Target((vector.X, vector.Y, vector.Z));

        Assert.Equal(vector, actual);
    }
}
