namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class AsIPrefix_Factor
{
    private static Scalar Target(BinaryPrefix prefix)
    {
        return execute(prefix);

        static Scalar execute(IPrefix prefix) => prefix.Factor;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Common_EqualsBinaryPrefixProperty(BinaryPrefix prefix)
    {
        var actual = Target(prefix);

        Assert.Equal(prefix.Factor, actual);
    }
}
