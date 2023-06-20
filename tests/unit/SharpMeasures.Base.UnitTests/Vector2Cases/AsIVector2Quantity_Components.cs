namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class AsIVector2Quantity_Components
{
    private static Vector2 Target(Vector2 vector)
    {
        return execute(vector);

        static Vector2 execute(IVector2Quantity quantity) => quantity.Components;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedVector2(Vector2 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
