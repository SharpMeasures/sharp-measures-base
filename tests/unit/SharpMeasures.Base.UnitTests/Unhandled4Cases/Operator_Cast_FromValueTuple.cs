namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Cast_FromValueTuple
{
    private static Unhandled4 Target((Unhandled, Unhandled, Unhandled, Unhandled) components) => (Unhandled4)components;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled4_EqualsProvidedUnhandled4(Unhandled4 vector)
    {
        var actual = Target((vector.X, vector.Y, vector.Z, vector.W));

        Assert.Equal(vector, actual);
    }
}
