﻿namespace SharpMeasures.Unhandled2Cases;

using System;

using Xunit;

public sealed class Multiply_TScalar
{
    private static Unhandled2 Target<TScalar>(Unhandled2 vector, TScalar factor) where TScalar : IScalarQuantity => vector.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled2 vector) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationOfComponentsByMagnitude(Unhandled2 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationOfComponentsByMagnitude(Unhandled2 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationOfComponentsByMagnitude(Unhandled2 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationOfComponentsByMagnitude(Unhandled2 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationOfComponentsByMagnitude(Unhandled2 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationOfComponentsByMagnitude(Unhandled2 vector) => EqualsMultiplicationOfComponentsByMagnitude(vector, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiplicationOfComponentsByMagnitude<TScalar>(Unhandled2 vector, TScalar factor) where TScalar : IScalarQuantity
    {
        Unhandled2 expected = new(vector.Components * factor.Magnitude);
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled2 vector, TScalar factor) where TException : Exception where TScalar : IScalarQuantity
    {
        var exception = Record.Exception(() => Target(vector, factor));

        Assert.IsType<TException>(exception);
    }
}
