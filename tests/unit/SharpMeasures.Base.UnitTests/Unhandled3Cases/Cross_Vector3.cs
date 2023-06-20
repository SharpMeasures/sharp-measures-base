namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Cross_Vector3
{
    private static Unhandled3 Target(Unhandled3 vector, Vector3 factor) => vector.Cross(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector, Vector3 factor)
    {
        Unhandled3 expected = new(vector.Components.Cross(factor));
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
