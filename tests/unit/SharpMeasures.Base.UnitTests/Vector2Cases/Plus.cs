namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Plus
{
    private static Vector2 Target(Vector2 vector) => vector.Plus();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedVector2(Vector2 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
