namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Add_Vector3
{
    private static Vector3 Target(Vector3 vector, Vector3 addend) => vector.Add(addend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsAdditionOfComponents(Vector3 vector) => EqualsAdditionOfComponents(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsAdditionOfComponents(Vector3 vector) => EqualsAdditionOfComponents(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsAdditionOfComponents(Vector3 vector) => EqualsAdditionOfComponents(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsAdditionOfComponents(Vector3 vector) => EqualsAdditionOfComponents(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsAdditionOfComponents(Vector3 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsAdditionOfComponents(Vector3 vector) => EqualsAdditionOfComponents(vector, (-1.5, -4.5, -7.5));

    [AssertionMethod]
    private static void EqualsAdditionOfComponents(Vector3 vector, Vector3 addend)
    {
        Vector3 expected = (vector.X + addend.X, vector.Y + addend.Y, vector.Z + addend.Z);
        var actual = Target(vector, addend);

        Assert.Equal(expected, actual);
    }
}
