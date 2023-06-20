namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Plus
{
    private static Vector3 Target(Vector3 vector) => vector.Plus();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedVector3(Vector3 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
