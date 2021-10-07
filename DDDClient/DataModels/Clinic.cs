using System.Collections.Generic;
using DDDClient.Abstractions;

namespace DDDClient.DataModels
{
    internal record Clinic(int Id, string Name)
    {
        public IList<Patient> Patients { get; } = new List<Patient>();
    }
}