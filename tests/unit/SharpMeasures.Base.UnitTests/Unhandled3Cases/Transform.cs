namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Transform
{
    private static Unhandled3 Target(Unhandled3 vector, System.Numerics.Matrix4x4 transform) => vector.Transform(transform);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsOfComponentsTransform(Unhandled3 vector) => EqualsComponentsOfComponentsTransform(vector, new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Identity_EqualsComponentsOfComponentsTransform(Unhandled3 vector) => EqualsComponentsOfComponentsTransform(vector, System.Numerics.Matrix4x4.Identity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Valued_EqualsComponentsOfComponentsTransform(Unhandled3 vector) => EqualsComponentsOfComponentsTransform(vector, new(-22.5f, -19.5f, -16.5f, -13.5f, -10.5f, -7.5f, -4.5f, -1.5f, 1.5f, 4.5f, 7.5f, 10.5f, 13.5f, 16.5f, 19.5f, 22.5f));

    [AssertionMethod]
    private static void EqualsComponentsOfComponentsTransform(Unhandled3 vector, System.Numerics.Matrix4x4 transform)
    {
        Unhandled3 expected = new(vector.Components.Transform(transform));

        var actual = Target(vector, transform);

        Assert.Equal(expected, actual);
    }
}
