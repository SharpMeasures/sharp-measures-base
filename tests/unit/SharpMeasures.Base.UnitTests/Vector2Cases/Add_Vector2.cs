namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Add_Vector2
{
    private static Vector2 Target(Vector2 vector, Vector2 addend) => vector.Add(addend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsAdditionOfComponents(Vector2 vector) => EqualsAdditionOfComponents(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsAdditionOfComponents(Vector2 vector) => EqualsAdditionOfComponents(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsAdditionOfComponents(Vector2 vector) => EqualsAdditionOfComponents(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsAdditionOfComponents(Vector2 vector) => EqualsAdditionOfComponents(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsAdditionOfComponents(Vector2 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsAdditionOfComponents(Vector2 vector) => EqualsAdditionOfComponents(vector, (-1.5, -4.5));

    [AssertionMethod]
    private static void EqualsAdditionOfComponents(Vector2 vector, Vector2 addend)
    {
        Vector2 expected = (vector.X + addend.X, vector.Y + addend.Y);
        var actual = Target(vector, addend);

        Assert.Equal(expected, actual);
    }
}
