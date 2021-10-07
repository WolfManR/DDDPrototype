using DDDClient.Abstractions;

namespace DDDClient.DataModels
{
    internal record BloodAnalysis(int Id) : Analysis(Id, "Blood Analysis");
}