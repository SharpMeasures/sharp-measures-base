namespace SharpMeasures.Vector3Cases;

using System;

using Xunit;

public sealed class Multiply_TScalar
{
    private static (TScalar, TScalar, TScalar) Target<TScalar>(Vector3 vector, TScalar factor) where TScalar : IScalarQuantity<TScalar> => vector.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Vector3 vector) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationOfComponentsByMagnitude(Vector3 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationOfComponentsByMagnitude(Vector3 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationOfComponentsByMagnitude(Vector3 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationOfComponentsByMagnitude(Vector3 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationOfComponentsByMagnitude(Vector3 vector) => EqualsMultiplicationOfComponentsByMagnitude<Scalar>(vector, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationOfComponentsByMagnitude(Vector3 vector) => EqualsMultiplicationOfComponentsByMagnitude<Scalar>(vector, -1.5);

    [AssertionMethod]
    private static void EqualsMultiplicationOfComponentsByMagnitude<TScalar>(Vector3 vector, TScalar factor) where TScalar : IScalarQuantity<TScalar>
    {
        var expected = vector.Multiply(factor.Magnitude);
        var (actualX, actualY, actualZ) = Target(vector, factor);

        Assert.Equal(expected, new Vector3(actualX.Magnitude, actualY.Magnitude, actualZ.Magnitude));
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Vector3 vector, TScalar factor) where TException : Exception where TScalar : IScalarQuantity<TScalar>
    {
        var exception = Record.Exception(() => Target(vector, factor));

        Assert.IsType<TException>(exception);
    }
}
