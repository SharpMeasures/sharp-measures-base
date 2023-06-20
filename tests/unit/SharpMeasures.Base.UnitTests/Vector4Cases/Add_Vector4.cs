namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Add_Vector4
{
    private static Vector4 Target(Vector4 vector, Vector4 addend) => vector.Add(addend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsAdditionOfComponents(Vector4 vector) => EqualsAdditionOfComponents(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsAdditionOfComponents(Vector4 vector) => EqualsAdditionOfComponents(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsAdditionOfComponents(Vector4 vector) => EqualsAdditionOfComponents(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsAdditionOfComponents(Vector4 vector) => EqualsAdditionOfComponents(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsAdditionOfComponents(Vector4 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsAdditionOfComponents(Vector4 vector) => EqualsAdditionOfComponents(vector, (-1.5, -4.5, -7.5, -10.5));

    [AssertionMethod]
    private static void EqualsAdditionOfComponents(Vector4 vector, Vector4 addend)
    {
        Vector4 expected = (vector.X + addend.X, vector.Y + addend.Y, vector.Z + addend.Z, vector.W + addend.W);
        var actual = Target(vector, addend);

        Assert.Equal(expected, actual);
    }
}
