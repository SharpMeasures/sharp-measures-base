namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Operator_Cast_ToValueTuple
{
    private static (Scalar, Scalar, Scalar) Target(Vector3 vector) => ((Scalar, Scalar, Scalar))vector;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsToValueTuple(Vector3 vector)
    {
        var expected = vector.ToValueTuple();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
