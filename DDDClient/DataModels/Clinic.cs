using System.Collections.Generic;
using DDDClient.Abstractions;

namespace DDDClient.DataModels
{
    internal record Clinic(int Id, string Name, IList<Patient> Patients);
}