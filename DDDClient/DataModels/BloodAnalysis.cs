using DDDClient.Abstractions;

namespace DDDClient.DataModels
{
    internal record BloodAnalysis(int Id, string Description, decimal Price, Patient Patient) : Analysis(Id, Description, Price, Patient);
}