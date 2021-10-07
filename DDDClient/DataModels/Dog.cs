using System.Collections.Generic;
using DDDClient.Abstractions;

namespace DDDClient.DataModels
{
    internal record Dog(int Id, string Name) : Patient(Id, Name);
}