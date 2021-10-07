using DDDClient.Abstractions;

namespace DDDClient.DataModels
{
    internal record InspectionAnalysis(int Id) : Analysis(Id, "Inspection Analysis");
}