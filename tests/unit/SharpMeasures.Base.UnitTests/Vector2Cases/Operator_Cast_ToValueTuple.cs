namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Cast_ToValueTuple
{
    private static (Scalar, Scalar) Target(Vector2 vector) => ((Scalar, Scalar))vector;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsToValueTuple(Vector2 vector)
    {
        var expected = vector.ToValueTuple();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
