namespace SharpMeasures.MetricPrefixCases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
internal sealed class Dataset : ATestDataset<MetricPrefix>
{
    protected override IEnumerable<MetricPrefix> GetSamples() => new[]
    {
        MetricPrefix.Zero,
        MetricPrefix.TenToThePower(0),
        MetricPrefix.TenToThePower(1),
        MetricPrefix.TenToThePower(-1),
        MetricPrefix.TenToThePower(100),
        MetricPrefix.TenToThePower(int.MinValue)
    };
}
