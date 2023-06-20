namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Cast_ToValueTuple
{
    private static (Unhandled, Unhandled, Unhandled) Target(Unhandled3 vector) => ((Unhandled, Unhandled, Unhandled))vector;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsToValueTuple(Unhandled3 vector)
    {
        var expected = vector.ToValueTuple();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
