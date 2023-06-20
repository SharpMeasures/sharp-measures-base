namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class ToValueTuple
{
    private static (Scalar, Scalar) Target(Vector2 vector) => vector.ToValueTuple();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsOfProvidedVector2(Vector2 vector)
    {
        var actual = Target(vector);

        Assert.Equal((vector.X, vector.Y), actual);
    }
}
