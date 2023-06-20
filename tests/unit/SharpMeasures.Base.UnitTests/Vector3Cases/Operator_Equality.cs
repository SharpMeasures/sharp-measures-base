namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(Vector3 lhs, Vector3 rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(Vector3 lhs) => EqualsEqualsMethod(lhs, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(Vector3 rhs) => EqualsEqualsMethod(Vector3.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsEqualsMethod(Vector3 lhs) => EqualsEqualsMethod(lhs, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsEqualsMethod(Vector3 rhs) => EqualsEqualsMethod(Scalar.NaN * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsEqualsMethod(Vector3 lhs) => EqualsEqualsMethod(lhs, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsEqualsMethod(Vector3 rhs) => EqualsEqualsMethod(Scalar.PositiveInfinity * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsEqualsMethod(Vector3 lhs) => EqualsEqualsMethod(lhs, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsEqualsMethod(Vector3 rhs) => EqualsEqualsMethod(Scalar.NegativeInfinity * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsEqualsMethod(Vector3 lhs) => EqualsEqualsMethod(lhs, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsEqualsMethod(Vector3 rhs) => EqualsEqualsMethod((1.5, 4.5, 7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsEqualsMethod(Vector3 lhs) => EqualsEqualsMethod(lhs, (-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsEqualsMethod(Vector3 rhs) => EqualsEqualsMethod((-1.5, -4.5, -7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector3s_EqualsEqualsMethod(Vector3 vector) => EqualsEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsEqualsMethod(Vector3 lhs, Vector3 rhs)
    {
        var expected = Vector3.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
