namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Cast_FromValueTuple
{
    private static Unhandled3 Target((Unhandled, Unhandled, Unhandled) components) => (Unhandled3)components;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled3_EqualsProvidedUnhandled3(Unhandled3 vector)
    {
        var actual = Target((vector.X, vector.Y, vector.Z));

        Assert.Equal(vector, actual);
    }
}
