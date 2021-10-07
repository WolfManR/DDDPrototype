using System.Collections.Generic;
using DDDClient.Abstractions;

namespace DDDClient.DataModels
{
    internal record Kitten(int Id, string Name) : Patient(Id, Name);
}