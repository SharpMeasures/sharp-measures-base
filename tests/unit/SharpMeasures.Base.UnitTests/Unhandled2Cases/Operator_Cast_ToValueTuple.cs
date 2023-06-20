namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Operator_Cast_ToValueTuple
{
    private static (Unhandled, Unhandled) Target(Unhandled2 vector) => ((Unhandled, Unhandled))vector;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsToValueTuple(Unhandled2 vector)
    {
        var expected = vector.ToValueTuple();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
