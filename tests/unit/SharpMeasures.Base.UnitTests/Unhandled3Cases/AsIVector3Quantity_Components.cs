namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class AsIVector3Quantity_Components
{
    private static Vector3 Target(Unhandled3 vector)
    {
        return execute(vector);

        static Vector3 execute(IVector3Quantity quantity) => quantity.Components;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsUnhandled3Components(Unhandled3 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector.Components, actual);
    }
}
