namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Plus
{
    private static Vector4 Target(Vector4 vector) => vector.Plus();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedVector4(Vector4 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
