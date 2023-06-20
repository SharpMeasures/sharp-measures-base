namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Transform
{
    private static Vector3 Target(Vector3 vector, System.Numerics.Matrix4x4 transform) => vector.Transform(transform);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsArithmeticTransform(Vector3 vector) => EqualsArithmeticTransform(vector, new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Identity_EqualsArithmeticTransform(Vector3 vector) => EqualsArithmeticTransform(vector, System.Numerics.Matrix4x4.Identity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Valued_EqualsArithmeticTransform(Vector3 vector) => EqualsArithmeticTransform(vector, new(-22.5f, -19.5f, -16.5f, -13.5f, -10.5f, -7.5f, -4.5f, -1.5f, 1.5f, 4.5f, 7.5f, 10.5f, 13.5f, 16.5f, 19.5f, 22.5f));

    [AssertionMethod]
    private static void EqualsArithmeticTransform(Vector3 vector, System.Numerics.Matrix4x4 transform)
    {
        Vector3 expected =
        (
            (vector.X * transform.M11) + (vector.Y * transform.M21) + (vector.Z * transform.M31) + transform.M41,
            (vector.X * transform.M12) + (vector.Y * transform.M22) + (vector.Z * transform.M32) + transform.M42,
            (vector.X * transform.M13) + (vector.Y * transform.M23) + (vector.Z * transform.M33) + transform.M43
        );

        var actual = Target(vector, transform);

        Assert.Equal(expected, actual);
    }
}
