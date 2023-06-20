﻿namespace SharpMeasures.Unhandled4Cases;

using System;

using Xunit;

public sealed class Subtract_TVector
{
    private static Unhandled4 Target<TVector>(Unhandled4 vector, TVector subtrahend) where TVector : IVector4Quantity => vector.Subtract(subtrahend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled4 vector) => ThrowsException<ArgumentNullException, ReferenceVector4Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsSubtractionOfComponents(Unhandled4 vector) => EqualsSubtractionOfComponents(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsSubtractionOfComponents(Unhandled4 vector) => EqualsSubtractionOfComponents(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsSubtractionOfComponents(Unhandled4 vector) => EqualsSubtractionOfComponents(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsSubtractionOfComponents(Unhandled4 vector) => EqualsSubtractionOfComponents(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsSubtractionOfComponents(Unhandled4 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsSubtractionOfComponents(Unhandled4 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsSubtractionOfComponents<TVector>(Unhandled4 vector, TVector subtrahend) where TVector : IVector4Quantity
    {
        Unhandled4 expected = new(vector.Components - subtrahend.Components);
        var actual = Target(vector, subtrahend);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled4 vector, TVector subtrahend) where TException : Exception where TVector : IVector4Quantity
    {
        var exception = Record.Exception(() => Target(vector, subtrahend));

        Assert.IsType<TException>(exception);
    }
}
