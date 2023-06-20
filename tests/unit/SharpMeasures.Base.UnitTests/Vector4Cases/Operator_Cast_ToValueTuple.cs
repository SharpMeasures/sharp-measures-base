namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Cast_ToValueTuple
{
    private static (Scalar, Scalar, Scalar, Scalar) Target(Vector4 vector) => ((Scalar, Scalar, Scalar, Scalar))vector;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsToValueTuple(Vector4 vector)
    {
        var expected = vector.ToValueTuple();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
