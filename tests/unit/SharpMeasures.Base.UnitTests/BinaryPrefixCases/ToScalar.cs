namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class ToScalar
{
    private static Scalar Target(BinaryPrefix prefix) => prefix.ToScalar();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Common_EqualsFactor(BinaryPrefix prefix)
    {
        var actual = Target(prefix);

        Assert.Equal(prefix.Factor, actual);
    }
}
