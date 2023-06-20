namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class ToValueTuple
{
    private static (Scalar, Scalar, Scalar) Target(Vector3 vector) => vector.ToValueTuple();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsOfProvidedVector3(Vector3 vector)
    {
        var actual = Target(vector);

        Assert.Equal((vector.X, vector.Y, vector.Z), actual);
    }
}
