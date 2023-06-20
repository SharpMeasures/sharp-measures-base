namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class FromValueTuple
{
    private static Unhandled2 Target((Unhandled, Unhandled) components) => Unhandled2.FromValueTuple(components);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled2_EqualsProvidedUnhandled2(Unhandled2 vector)
    {
        var actual = Target((vector.X, vector.Y));

        Assert.Equal(vector, actual);
    }
}
