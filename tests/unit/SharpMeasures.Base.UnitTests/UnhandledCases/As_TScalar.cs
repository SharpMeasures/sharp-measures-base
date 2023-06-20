namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class As_TScalar
{
    private static TScalar Target<TScalar>(Unhandled unhandled) where TScalar : IScalarQuantity<TScalar> => unhandled.As<TScalar>();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Scalar_EqualMagnitude(Unhandled unhandled) => EqualMagnitude<Scalar>(unhandled);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ReferenceType_EqualMagnitude(Unhandled unhandled) => EqualMagnitude<ReferenceScalarQuantity>(unhandled);

    [AssertionMethod]
    private static void EqualMagnitude<TScalar>(Unhandled unhandled) where TScalar : IScalarQuantity<TScalar>
    {
        var actual = Target<TScalar>(unhandled);

        Assert.Equal(unhandled.Magnitude, actual.Magnitude);
    }
}
