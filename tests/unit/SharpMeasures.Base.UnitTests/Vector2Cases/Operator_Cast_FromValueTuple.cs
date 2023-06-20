namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Cast_FromValueTuple
{
    private static Vector2 Target((Scalar, Scalar) components) => (Vector2)components;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedVector2_EqualsProvidedVector2(Vector2 vector)
    {
        var actual = Target((vector.X, vector.Y));

        Assert.Equal(vector, actual);
    }
}
