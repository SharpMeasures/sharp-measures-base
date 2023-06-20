namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Plus
{
    private static Unhandled2 Target(Unhandled2 vector) => vector.Plus();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedUnhandled2(Unhandled2 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
