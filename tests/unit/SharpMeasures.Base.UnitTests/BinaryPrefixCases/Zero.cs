namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Zero
{
    private static BinaryPrefix Target() => BinaryPrefix.Zero;

    [Fact]
    public void FactorIsZero()
    {
        var actual = Target().Factor;

        Assert.Equal(0, actual);
    }
}
