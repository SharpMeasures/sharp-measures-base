namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Constructor_Scalars
{
    private static Vector3 Target(Scalar x, Scalar y, Scalar z) => new(x, y, z);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedVector3_EqualsProvidedVector3(Vector3 vector)
    {
        var actual = Target(vector.X, vector.Y, vector.Z);

        Assert.Equal(vector, actual);
    }
}
