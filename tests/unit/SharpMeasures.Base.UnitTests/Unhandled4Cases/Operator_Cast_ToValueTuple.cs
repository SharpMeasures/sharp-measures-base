namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Cast_ToValueTuple
{
    private static (Unhandled, Unhandled, Unhandled, Unhandled) Target(Unhandled4 vector) => ((Unhandled, Unhandled, Unhandled, Unhandled))vector;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsToValueTuple(Unhandled4 vector)
    {
        var expected = vector.ToValueTuple();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
