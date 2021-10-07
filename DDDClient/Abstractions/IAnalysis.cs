namespace DDDClient.Abstractions
{
    internal interface IAnalysis : ILabor
    {
        Patient Patient { get; }
    }
}