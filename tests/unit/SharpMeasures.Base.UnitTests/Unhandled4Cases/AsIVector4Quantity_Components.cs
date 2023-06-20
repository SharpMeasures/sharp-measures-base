namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVector4Quantity_Components
{
    private static Vector4 Target(Unhandled4 vector)
    {
        return execute(vector);

        static Vector4 execute(IVector4Quantity quantity) => quantity.Components;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsUnhandled4Components(Unhandled4 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector.Components, actual);
    }
}
