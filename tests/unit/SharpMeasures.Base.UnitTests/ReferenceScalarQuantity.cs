namespace SharpMeasures;

using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used to refer to a nullable scalar quantity.")]
internal sealed record class ReferenceScalarQuantity : IScalarQuantity<ReferenceScalarQuantity>
{
    public Scalar Magnitude { get; private init; }

    static ReferenceScalarQuantity IScalarQuantity<ReferenceScalarQuantity>.WithMagnitude(Scalar magnitude) => new() { Magnitude = magnitude };
}
