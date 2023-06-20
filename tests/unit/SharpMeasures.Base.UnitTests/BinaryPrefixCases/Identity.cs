namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Identity
{
    private static BinaryPrefix Target() => BinaryPrefix.Identity;

    [Fact]
    public void FactorIsOne()
    {
        var actual = Target().Factor;

        Assert.Equal(Scalar.One, actual);
    }
}
