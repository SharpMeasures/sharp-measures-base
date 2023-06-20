namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Operator_Cast_ToScalar
{
    private static Scalar Target(BinaryPrefix prefix) => (Scalar)prefix;

    [Fact]
    public void Null_ArgumentNullException() => ThrowsException<ArgumentNullException>(null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonNull_EqualsToScalarMethod(BinaryPrefix prefix)
    {
        var expected = prefix.ToScalar();
        var actual = Target(prefix);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(BinaryPrefix prefix) where TException : Exception
    {
        var exception = Record.Exception(() => Target(prefix));

        Assert.IsType<TException>(exception);
    }
}
